/*
 * Created by SharpDevelop.
 * User: LinJay
 * Date: 07.08.2015
 * Time: 0:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Коллекция_фильмов
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			EditForm = new EditForm(this);
		
			/*Create an instance of a ListView column sorter and assign it 
			to the ListView control.
			lvwColumnSorter = new ListViewColumnSorter();
			this.FilmsCollection.ListViewItemSorter = lvwColumnSorter;
			*/
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//private ListViewColumnSorter lvwColumnSorter;
		EditForm EditForm;
		public string CurrentMode="Review";
		public bool IsEmptyValue;
		public int FilmCount;
		public string FilmQuantity;
		public int sortColumn = -1;
		//FileStream File = new FileStream("program.txt",FileMode.OpenOrCreate);
		
		public void FormRefresh()
		{	FilmQuantityEnder();
			FilmNameLabel.ResetText();
			FilmAddedDateLabel.ResetText();
			FilmRatingLabel.ResetText();
			FilmCommentTB.ResetText();
			if (CurrentMode=="Review")
			{	ReviewModeTSMI.Checked=true;
				TimeTableModeTSMI.Checked=false;
				FilmsCollection.Columns[1].Text="Дата просмотра";
				HintFilmAddedDateLabel.Text="Дата просмотра:";
				EditForm.EditFilmAddedDateLabel.Text="Дата просмотра";
				FilmsCollection.Columns[2].Text="Оценка";
				EditForm.EditFilmRatingLabel.Text="Оценка";
				FilmsCollection.Columns[3].Text="Отзыв о фильме";
				HintFilmCommentLabel.Text="Отзыв о фильме:";
				EditForm.EditFilmCommentLabel.Text="Отзыв о фильме";
				CurrentModeLabel.Text="В режиме рецензии Вы можете оставить ранее просмотренному Вами фильму оценку и небольшой отзыв.";
				FilmsQuantityInfoLabel.Text="На текущий момент в коллекцию добавлен" + FilmQuantity;
				this.Refresh();
			}
			else
			{	ReviewModeTSMI.Checked=false;
				TimeTableModeTSMI.Checked=true;
				FilmsCollection.Columns[1].Text="Дата добавления";
				HintFilmAddedDateLabel.Text="Дата добавления:";
				EditForm.EditFilmAddedDateLabel.Text="Дата добавления";
				FilmsCollection.Columns[2].Text="Приоритет";
				EditForm.EditFilmRatingLabel.Text="Приоритет";
				FilmsCollection.Columns[3].Text="Описание к фильму";
				HintFilmCommentLabel.Text="Описание к фильму:";
				EditForm.EditFilmCommentLabel.Text="Описание к фильму";
				CurrentModeLabel.Text="В режиме расписания Вы можете добавить желаемые или планируемые к просмотру фильмы, указать приоритет и оставить небольшое описание.";
				FilmsQuantityInfoLabel.Text="На текущий момент в коллекцию добавлен" + FilmQuantity;
				this.Refresh();
			}
		}
		void FilmQuantityEnder()
		{	FilmCount=FilmsCollection.Items.Count;
			if(FilmCount%10==1&&FilmCount!=11) FilmQuantity=" " + FilmCount + " фильм.";
			else 
			{	if((FilmCount%10==2&&FilmCount!=12)||(FilmCount%10==3&&FilmCount!=13)||(FilmCount%10==4&&FilmCount!=14))
				FilmQuantity="о " + FilmCount + " фильма.";
				else FilmQuantity="о " + FilmCount + " фильмов.";
			}
		}
		void LoadCollection()
		{	FilmsCollection.Items.Clear();
			if(File.Exists(CurrentMode+".collection")==true)
			{
				string[] items = File.ReadAllLines(CurrentMode+".collection");
				foreach (var item in items)
				{FilmsCollection.Items.Add(new ListViewItem(item.Split('\t')));}
				FormRefresh();
			}
		}
		void SaveCollection()
		{	StreamWriter writer = File.CreateText(CurrentMode+".collection");
            StringBuilder builder = new StringBuilder();
            foreach (ListViewItem item in FilmsCollection.Items)
            {
                /*//This Code, maybe, will not be used anymore
 				foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    builder.Append(subItem.Text).Append('\t');
                }
                writer.WriteLine(builder);
                builder.Clear();*/
                for (int ls = 0; ls < 3; ls++) 
                {writer.Write("{0}\t", item.SubItems[ls].Text);
                }
                writer.Write("{0}\n", item.SubItems[3].Text);
            }
            writer.Close();
            FilmsCollection.Items.Clear();
		}
		
		void AddFilmButtonClick(object sender, EventArgs e)
		{	IsEmptyValue=true;
			EditForm.EditFilmNameTB.Text="";
			EditForm.EditFilmCommentTB.Text="";
			EditForm.EditFilmAddedDate.Value=DateTime.Today;
			EditForm.Star0();
			EditForm.ShowDialog();
		}
		void EditFilmButtonClick(object sender, EventArgs e)
		{	if(FilmsCollection.SelectedItems.Count==0) FilmNameLabel.Text="Фильм не выбран!"; 
			else 
			{	IsEmptyValue=false;
				switch (FilmsCollection.FocusedItem.SubItems[2].Text)
				{	case "★☆☆☆☆": EditForm.Star1Click(sender,e); break;
					case "★★☆☆☆": EditForm.Star2Click(sender,e); break;
					case "★★★☆☆": EditForm.Star3Click(sender,e); break;
					case "★★★★☆": EditForm.Star4Click(sender,e); break;
					case "★★★★★": EditForm.Star5Click(sender,e); break;
					default: EditForm.Star0(); break;
				}
				EditForm.EditFilmNameTB.Text=FilmsCollection.FocusedItem.Text;
				EditForm.EditFilmAddedDate.Value=DateTime.Parse(FilmsCollection.FocusedItem.SubItems[1].Text);
				EditForm.EditFilmCommentTB.Text=FilmsCollection.FocusedItem.SubItems[3].Text;
				EditForm.ShowDialog();
			}
		}
		void RemoveFilmButtonClick(object sender, EventArgs e)
		{	if(FilmsCollection.SelectedItems.Count==0) FilmNameLabel.Text="Фильм не выбран!"; 
			else 
			{	FilmsCollection.FocusedItem.Remove();
				FormRefresh();
			}
		}
		
		void ReviewModeTSMIClick(object sender, EventArgs e)
		{	SaveCollection();
			CurrentMode="Review";
			LoadCollection();
			FormRefresh();
		}
		void TimeTableModeTSMIClick(object sender, EventArgs e)
		{	SaveCollection();
			CurrentMode="TimeTable";
			LoadCollection();
			FormRefresh();
		}
		void AuthorsProfileTSMIClick(object sender, EventArgs e)
		{	System.Diagnostics.Process.Start("https://vk.com/id90781995");}
		void FindInGoogleTSMIClick(object sender, EventArgs e)
		{	System.Diagnostics.Process.Start("https://www.google.com");}
		void CloseAppTSMIClick(object sender, EventArgs e)
		{	Application.Exit();}
		
		void FilmsCollectionItemActivate(object sender, EventArgs e)
		{	FilmNameLabel.Text=FilmsCollection.FocusedItem.SubItems[0].Text;
			FilmAddedDateLabel.Text=FilmsCollection.FocusedItem.SubItems[1].Text;
			FilmRatingLabel.Text=FilmsCollection.FocusedItem.SubItems[2].Text;
			FilmCommentTB.Text=FilmsCollection.FocusedItem.SubItems[3].Text;		
		}
		void FilmsCollectionSelectedIndexChanged(object sender, EventArgs e)
		{	FormRefresh();
			try{FilmsCollectionItemActivate(sender,e);}
			catch(NullReferenceException){;}
		}
		void FilmsCollectionColumnClick(object sender, ColumnClickEventArgs e)
		{	// Определение того, совпадает ли столбец с последним выбранным столбцом.
			if (e.Column != sortColumn)
		    {	// Установка сортировки нового столбца.
		        sortColumn = e.Column;
		        // Установка порядка сортировки "по возрастанию" как порядка по умолчанию.
		        FilmsCollection.Sorting = SortOrder.Ascending;
		    }
		    else
		    {	// Определение и последующее изменение последнего порядка сортировки.
		        if (FilmsCollection.Sorting == SortOrder.Ascending)
		            FilmsCollection.Sorting = SortOrder.Descending;
		        else
		            FilmsCollection.Sorting = SortOrder.Ascending;
		   }
		
		    // Вызов метода ручной сортировки.
		    this.FilmsCollection.Sort();
		    // Установка свойства ListViewItemSorter на новый объект ListViewItemComparer.
			this.FilmsCollection.ListViewItemSorter = new ListViewItemComparer(e.Column, FilmsCollection.Sorting);
			/*
			if ( e.Column == lvwColumnSorter.SortColumn )
			{	if (lvwColumnSorter.Order == SortOrder.Ascending)
				{	lvwColumnSorter.Order = SortOrder.Descending;
				}
				else
				{	lvwColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{	lvwColumnSorter.SortColumn = e.Column;
				lvwColumnSorter.Order = SortOrder.Ascending;
			}
			this.FilmsCollection.Sort();
			*/				
		}
		
		void ContextMenuBlockOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{	if(FilmsCollection.SelectedItems.Count==0) e.Cancel=true;}
		void CopyTheHeaderCMSClick(object sender, EventArgs e)
		{	Clipboard.SetText(FilmsCollection.FocusedItem.Text);}
		

		void MainFormLoad(object sender, EventArgs e)
		{	LoadCollection();
			FormRefresh();
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{	SaveCollection();
		}
		
		void AboutTSMIClick(object sender, EventArgs e)
		{MessageBox.Show("Коллекция фильмов\nДата создания: 8 августа 2015 г.\n" +
			"Автор программы: Александр \"LinJay\" Лысенко\n" +
			"Текущая версия: 1.1\nДата выхода этой версии: 19 августа 2015 г.\n\nЧто нового в этой версии:\n" +
			"● Изменения в интерфейсе и внешнем виде программы,\n" +
			"● Переработан алгоритм сохранения файлов коллекции,\n" +
			"✔ Исправлена проблема переключения элементов в списке при помощи клавиш,\n" +
			"✔ Исправлена сортировка столбца с датами,\n" +
			"✙ Добавлена возможность копировать название выделенного фильма через контекстное меню,\n" +
			"\nНаписать автору предложения, жалобы или информацию о найденных ошибках в программе можно на e-mail:\n" +
			"LinJay@ya.ru",
			"О программе \"Коллекция фильмов\" v1.1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
	}
}
