using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Коллекция_фильмов
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EditForm = new EditForm(this);
            AboutForm = new AboutForm();
        }

        EditForm EditForm;
        AboutForm AboutForm;
        public string CurrentMode = "Review";
        public bool IsEmptyValue;
        public int FilmCount;
        public string FilmQuantity;
        public int sortColumn = -1;
        public bool EmergencyCrash = false;

        [Serializable]
        public struct FilmsList
        {
            public string FilmName;
            public string FilmAddedTime;
            public string FilmRating;
            public string FilmComment;
        }

        public void FormRefresh()
        {
            FilmQuantityEnder();
            FilmNameLabel.ResetText();
            FilmAddedDateLabel.ResetText();
            FilmRatingLabel.ResetText();
            FilmCommentTB.ResetText();
            if (CurrentMode == "Review")
            {
                ReviewModeTSMI.Checked = true;
                TimeTableModeTSMI.Checked = false;
                FilmsCollection.Columns[1].Text = "Дата просмотра";
                HintFilmAddedDateLabel.Text = "Дата просмотра:";
                EditForm.EditFilmAddedDateLabel.Text = "Дата просмотра";
                FilmsCollection.Columns[2].Text = "Оценка";
                EditForm.EditFilmRatingLabel.Text = "Оценка";
                FilmsCollection.Columns[3].Text = "Отзыв о фильме";
                HintFilmCommentLabel.Text = "Отзыв о фильме:";
                EditForm.EditFilmCommentLabel.Text = "Отзыв о фильме";
                CurrentModeLabel.Text =
                    "В режиме рецензии Вы можете оставить ранее просмотренному Вами фильму оценку и небольшой отзыв.";
                FilmsQuantityInfoLabel.Text = "На текущий момент в коллекцию добавлен" + FilmQuantity;
                FilmCommentTB.Text = String.Empty;
                this.Refresh();
            }
            else
            {
                ReviewModeTSMI.Checked = false;
                TimeTableModeTSMI.Checked = true;
                FilmsCollection.Columns[1].Text = "Дата добавления";
                HintFilmAddedDateLabel.Text = "Дата добавления:";
                EditForm.EditFilmAddedDateLabel.Text = "Дата добавления";
                FilmsCollection.Columns[2].Text = "Приоритет";
                EditForm.EditFilmRatingLabel.Text = "Приоритет";
                FilmsCollection.Columns[3].Text = "Описание к фильму";
                HintFilmCommentLabel.Text = "Описание к фильму:";
                EditForm.EditFilmCommentLabel.Text = "Описание к фильму";
                CurrentModeLabel.Text =
                    "В режиме расписания Вы можете добавить желаемые или планируемые к просмотру фильмы, указать приоритет и оставить небольшое описание.";
                FilmsQuantityInfoLabel.Text = "На текущий момент в коллекцию добавлен" + FilmQuantity;
                FilmCommentTB.Text = String.Empty;
                this.Refresh();
            }
        }

        void FilmQuantityEnder()
        {
            FilmCount = FilmsCollection.Items.Count;
            if (FilmCount % 10 == 1 && FilmCount % 100 != 11) FilmQuantity = " " + FilmCount + " фильм.";
            else
            {
                if ((FilmCount % 10 == 2 && FilmCount % 100 != 12) || (FilmCount % 10 == 3 && FilmCount % 100 != 13) ||
                    (FilmCount % 10 == 4 && FilmCount % 100 != 14))
                    FilmQuantity = "о " + FilmCount + " фильма.";
                else FilmQuantity = "о " + FilmCount + " фильмов.";
            }
        }

        void LoadCollection()
        {
            FilmsCollection.Items.Clear();
            /*if(File.Exists(CurrentMode+".collection"))
            {
                string[] items = File.ReadAllLines(CurrentMode+".collection");
                foreach (var item in items)
                {FilmsCollection.Items.Add(new ListViewItem(item.Split('\t')));}
                FormRefresh();
            }*/
            BinaryFormatter BinFile = new BinaryFormatter();
            FilmsList[] FilmsList = new FilmsList[0];
            if (File.Exists(CurrentMode + ".collection"))
            {
                Stream OpenFile = new FileStream(CurrentMode + ".collection", FileMode.Open, FileAccess.Read,
                    FileShare.Read);
                try
                {
                    FilmsList = (FilmsList[]) BinFile.Deserialize(OpenFile);
                }
                catch
                {
                    OpenFile.Close();
                    EmergencyCrash = true;
                    File.Copy("Review.collection", "Review.old.collection", true);
                    File.Copy("TimeTable.collection", "TimeTable.old.collection", true);
                    RebuildCollectionFiles();
                    if (MessageBox.Show("Произошла ошибка чтения файла!\n" +
                                        "Возможно, версия Ваших файлов коллекции не совпадает с новым бинарным стандартом, \n" +
                                        "поэтому сейчас программа автоматически перестроит их и перезапустится.\n" +
                                        "Ваши данные не будут повреждены! \n" +
                                        "Ни в коем случае не редактируйте файлы коллекции вручную!\n\n" +
                                        "Оставить Вам на память старые версии файлов коллекции?",
                            "Упс... Не переживайте, все под контролем!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) ==
                        DialogResult.No)
                    {
                        File.Delete("Review.old.collection");
                        File.Delete("TimeTable.old.collection");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Копии файлов коллекции находятся в папке с программой, с добавлением \"*.old\" в конце названия. Приятного использования!",
                            "Хорошо, мы их сохранили", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Application.Restart();
                }

                for (int i = 0; i < FilmsList.Length; i++)
                {
                    ListViewItem item = new ListViewItem(FilmsList[i].FilmName);
                    FilmsCollection.Items.Add(item);
                    item.SubItems.Add(FilmsList[i].FilmAddedTime);
                    item.SubItems.Add(FilmsList[i].FilmRating);
                    item.SubItems.Add(FilmsList[i].FilmComment);
                }
                OpenFile.Close();
            }
            FormRefresh();
        }

        void SaveCollection()
        {
            /*StreamWriter writer = File.CreateText(CurrentMode+".collection");
                        StringBuilder builder = new StringBuilder();
                        foreach (ListViewItem item in FilmsCollection.Items)
                        {   for (int ls = 0; ls < 3; ls++) 
                            {writer.Write("{0}\t", item.SubItems[ls].Text);
                            }
                            writer.Write("{0}\n", item.SubItems[3].Text);
                        }
                        writer.Close();*/
            FilmsList[] FilmsList = new FilmsList[FilmsCollection.Items.Count];
            for (int i = 0; i < FilmsCollection.Items.Count; i++)
            {
                FilmsList[i].FilmName = FilmsCollection.Items[i].SubItems[0].Text;
                FilmsList[i].FilmAddedTime = FilmsCollection.Items[i].SubItems[1].Text;
                FilmsList[i].FilmRating = FilmsCollection.Items[i].SubItems[2].Text;
                FilmsList[i].FilmComment = FilmsCollection.Items[i].SubItems[3].Text;
            }
            BinaryFormatter BinFile = new BinaryFormatter();
            Stream SaveFile = new FileStream(CurrentMode + ".collection", FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None);
            BinFile.Serialize(SaveFile, FilmsList);
            SaveFile.Close();



        }

        void AddFilmButtonClick(object sender, EventArgs e)
        {
            IsEmptyValue = true;
            EditForm.EditFilmNameTB.Text = "";
            EditForm.EditFilmCommentTB.Text = "";
            EditForm.EditFilmAddedDate.Value = DateTime.Today;
            EditForm.Star0();
            EditForm.ShowDialog();
        }

        void EditFilmButtonClick(object sender, EventArgs e)
        {
            if (FilmsCollection.SelectedItems.Count == 0) FilmNameLabel.Text = "Фильм не выбран!";
            else
            {
                IsEmptyValue = false;
                switch (FilmsCollection.FocusedItem.SubItems[2].Text)
                {
                    case "★☆☆☆☆":
                        EditForm.Star1Click(sender, e);
                        break;
                    case "★★☆☆☆":
                        EditForm.Star2Click(sender, e);
                        break;
                    case "★★★☆☆":
                        EditForm.Star3Click(sender, e);
                        break;
                    case "★★★★☆":
                        EditForm.Star4Click(sender, e);
                        break;
                    case "★★★★★":
                        EditForm.Star5Click(sender, e);
                        break;
                    default:
                        EditForm.Star0();
                        break;
                }
                EditForm.EditFilmNameTB.Text = FilmsCollection.FocusedItem.Text;
                EditForm.EditFilmAddedDate.Value = DateTime.Parse(FilmsCollection.FocusedItem.SubItems[1].Text);
                EditForm.EditFilmCommentTB.Text = FilmsCollection.FocusedItem.SubItems[3].Text;
                EditForm.ShowDialog();
            }
        }

        void RemoveFilmButtonClick(object sender, EventArgs e)
        {
            if (FilmsCollection.SelectedItems.Count == 0) FilmNameLabel.Text = "Фильм не выбран!";
            else
            {
                FilmsCollection.FocusedItem.Remove();
                FormRefresh();
            }
        }

        void ReviewModeTSMIClick(object sender, EventArgs e)
        {
            SaveCollection();
            CurrentMode = "Review";
            LoadCollection();
            FormRefresh();
        }

        void TimeTableModeTSMIClick(object sender, EventArgs e)
        {
            SaveCollection();
            CurrentMode = "TimeTable";
            LoadCollection();
            FormRefresh();
        }

        void AuthorsProfileTSMIClick(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/id90781995");
        }

        void FindInGoogleTSMIClick(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com");
        }

        void CloseAppTSMIClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void FilmsCollectionItemActivate(object sender, EventArgs e)
        {
            FilmNameLabel.Text = FilmsCollection.FocusedItem.SubItems[0].Text;
            FilmAddedDateLabel.Text = FilmsCollection.FocusedItem.SubItems[1].Text;
            FilmRatingLabel.Text = FilmsCollection.FocusedItem.SubItems[2].Text;
            FilmCommentTB.Text = FilmsCollection.FocusedItem.SubItems[3].Text;
        }

        void FilmsCollectionSelectedIndexChanged(object sender, EventArgs e)
        {
            FilmCommentTB.Refresh();
            try
            {
                FilmsCollectionItemActivate(sender, e);
            }
            catch (Exception)
            {
                ;
            }
        }

        void FilmsCollectionColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Определение того, совпадает ли столбец с последним выбранным столбцом.
            if (e.Column != sortColumn)
            {
                // Установка сортировки нового столбца.
                sortColumn = e.Column;
                // Установка порядка сортировки "по возрастанию" как порядка по умолчанию.
                FilmsCollection.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (FilmsCollection.Sorting == SortOrder.Ascending)
                    FilmsCollection.Sorting = SortOrder.Descending;
                else
                    FilmsCollection.Sorting = SortOrder.Ascending;
            }
            this.FilmsCollection.Sort();
            this.FilmsCollection.ListViewItemSorter = new ListViewItemComparer(e.Column, FilmsCollection.Sorting);
        }

        void ContextMenuBlockOpening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (FilmsCollection.SelectedItems.Count == 0) e.Cancel = true;
        }

        void CopyTheHeaderCMSClick(object sender, EventArgs e)
        {
            Clipboard.SetText(FilmsCollection.FocusedItem.Text);
        }


        void MainFormLoad(object sender, EventArgs e)
        {
            LoadCollection();
            FormRefresh();
        }

        void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!EmergencyCrash)
            {
                SaveCollection();
            }
        }

        void AboutTSMIClick(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();
        }

        public void RebuildCollectionFiles()
        {
            FilmsCollection.Items.Clear();
            if (File.Exists("Review.old.collection"))
            {
                string[] items = File.ReadAllLines("Review.old.collection");
                foreach (var item in items)
                {
                    FilmsCollection.Items.Add(new ListViewItem(item.Split('\t')));
                }
                this.Refresh();
            }
            FilmsList[] FilmsList = new FilmsList[FilmsCollection.Items.Count];
            for (int i = 0; i < FilmsCollection.Items.Count; i++)
            {
                FilmsList[i].FilmName = FilmsCollection.Items[i].SubItems[0].Text;
                FilmsList[i].FilmAddedTime = FilmsCollection.Items[i].SubItems[1].Text;
                FilmsList[i].FilmRating = FilmsCollection.Items[i].SubItems[2].Text;
                FilmsList[i].FilmComment = FilmsCollection.Items[i].SubItems[3].Text;
            }
            BinaryFormatter BinFile = new BinaryFormatter();
            Stream SerializeMe = new FileStream("Review.collection", FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None);
            BinFile.Serialize(SerializeMe, FilmsList);
            SerializeMe.Close();

            FilmsCollection.Items.Clear();
            if (File.Exists("TimeTable.old.collection"))
            {
                string[] items = File.ReadAllLines("TimeTable.old.collection");
                foreach (var item in items)
                {
                    FilmsCollection.Items.Add(new ListViewItem(item.Split('\t')));
                }
                this.Refresh();
            }
            FilmsList[] FilmsList2 = new FilmsList[FilmsCollection.Items.Count];
            for (int j = 0; j < FilmsCollection.Items.Count; j++)
            {
                FilmsList2[j].FilmName = FilmsCollection.Items[j].SubItems[0].Text;
                FilmsList2[j].FilmAddedTime = FilmsCollection.Items[j].SubItems[1].Text;
                FilmsList2[j].FilmRating = FilmsCollection.Items[j].SubItems[2].Text;
                FilmsList2[j].FilmComment = FilmsCollection.Items[j].SubItems[3].Text;
            }
            Stream SerializeMe2 = new FileStream("TimeTable.collection", FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None);
            BinFile.Serialize(SerializeMe2, FilmsList2);
            SerializeMe2.Close();
            return;
        }

        private void SaveToCSV_TSMI_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = "CSV|*.csv",
                InitialDirectory = Environment.SpecialFolder.Desktop.ToString()
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8);

                writer.Write("FilmName;FilmAddedTime;FilmRating;FilmComment\r\n");
                foreach (ListViewItem item in FilmsCollection.Items)
                {
                    for (int ls = 0; ls < 3; ls++)
                    {
                        writer.Write("{0};", item.SubItems[ls].Text);
                    }
                    writer.Write("{0}\r\n", item.SubItems[3].Text.Replace("\n", "\t"));
                }
                writer.Close();
                MessageBox.Show(String.Format("Файл сохранен в {0}", sfd.FileName),
                    "Файл успешно сохранен");
            }
        }
    }
}