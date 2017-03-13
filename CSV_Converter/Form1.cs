using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace CSV_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [Serializable]
        public struct FilmsList
        {
            public string FilmName;
            public string FilmAddedTime;
            public string FilmRating;
            public string FilmComment;
        }
        void LoadCollection(string path)
        {
            listView.Items.Clear();
            Text = "Конвертер коллекций фильмов в CSV-файлы";
            var binFile = new BinaryFormatter();
            var filmsList = new FilmsList[0];
            if (!File.Exists(path)) return;
            Stream openFile = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                filmsList = (FilmsList[])binFile.Deserialize(openFile);
                Text += " (Бинарная десериализация)";
            }
            catch (Exception ex)
            {
                throw;
                openFile.Close();
                Text += " (Альтернативное открытие)";
                string[] items = File.ReadAllLines(path);
                foreach (var item in items)
                { listView.Items.Add(new ListViewItem(item.Split('\t'))); }
            }

            for (int i = 0; i < filmsList.Length; i++)
            {
                ListViewItem item = new ListViewItem(filmsList[i].FilmName);
                item.SubItems.Add(filmsList[i].FilmAddedTime);
                item.SubItems.Add(filmsList[i].FilmRating);
                item.SubItems.Add(filmsList[i].FilmComment);
                listView.Items.Add(item);
            }
            openFile.Close();
        }
        private void openBtn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { InitialDirectory = Environment.SpecialFolder.Desktop.ToString() };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                openFileLabel.Text = ofd.FileName;
                LoadCollection(ofd.FileName);
            }
        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.Desktop
            };
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                savePathLabel.Text = fbd.SelectedPath;
            }

        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(File.Open(String.Format("{0}\\{1}.csv", savePathLabel.Text, newFileTb.Text), 
                FileMode.Create, FileAccess.Write));
            writer.Write("FilmName;FilmAddedTime;FilmRating;FilmComment\n");
            foreach (ListViewItem item in listView.Items)
            {
                for (int ls = 0; ls < 3; ls++)
                {
                    writer.Write("{0};", item.SubItems[ls].Text);
                }
                writer.Write("{0}\n", item.SubItems[3].Text);
            }
            writer.Close();
            MessageBox.Show(String.Format("Файл сохранен в {0}\\{1}.csv", savePathLabel.Text, newFileTb.Text),
                "Файл успешно сохранен");

        }
    }
}
