/*
 * Created by SharpDevelop.
 * User: LinJay
 * Date: 07.08.2015
 * Time: 3:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Коллекция_фильмов
{
	/// <summary>
	/// Description of EditForm.
	/// </summary>
	public partial class EditForm : Form
	{	//
		public EditForm(MainForm Form1)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			MainForm=Form1;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private MainForm MainForm;
		void EditFormFormClosing(object sender, FormClosingEventArgs e)
		{	e.Cancel = true;
			Hide();
		}
		
		public string Rating="☆☆☆☆☆";
		public bool Exists;
		public string VerifyString;
		void EditSaveButtonClick(object sender, EventArgs e)
		{	foreach(var Node in MainForm.FilmsCollection.Items)
					{	VerifyString="ListViewItem: {" + EditFilmNameTB.Text + "}";
					if (VerifyString.Equals(Node.ToString())&&MainForm.IsEmptyValue==true)
						{	MessageBox.Show("Такой фильм уже есть в коллекции","Ошибка. Обнаружен дубликат", MessageBoxButtons.OK, MessageBoxIcon.Error);
						EditFilmNameTB.Text="";
						return;
					}
					}
			{	if(EditFilmNameTB.Text=="")
				{	MessageBox.Show("Введите хотя бы название фильма.", "Недостаточно информации",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);}
				else
				{	if(MainForm.IsEmptyValue==true)
						{	MainForm.FilmsCollection.Items.Add(new ListViewItem(new string[]
							{EditFilmNameTB.Text,EditFilmAddedDate.Value.ToLongDateString(),Rating,EditFilmCommentTB.Text}));
						}
						else
						{	MainForm.FilmsCollection.FocusedItem.SubItems[0].Text=EditFilmNameTB.Text;
							MainForm.FilmsCollection.FocusedItem.SubItems[1].Text=EditFilmAddedDate.Value.ToLongDateString();
							MainForm.FilmsCollection.FocusedItem.SubItems[2].Text=Rating;
							MainForm.FilmsCollection.FocusedItem.SubItems[3].Text=EditFilmCommentTB.Text;
						}
					this.Close();
					MainForm.FormRefresh();
				}
			}
		}
		void EditCancelButtonClick(object sender, EventArgs e)
		{	
			EditFilmNameTB.Text="";
			EditFilmCommentTB.Text="";
			Rating="☆☆☆☆☆";
			this.Close();
		}
		public void Star0()
		{	Star1.Text="☆";
			Star2.Text="☆";
			Star3.Text="☆";
			Star4.Text="☆";
			Star5.Text="☆";
			Rating="☆☆☆☆☆";
		}
		public void Star1Click(object sender, EventArgs e)
		{	Star1.Text="★";
			Star2.Text="☆";
			Star3.Text="☆";
			Star4.Text="☆";
			Star5.Text="☆";
			Rating="★☆☆☆☆";
		}
		public void Star2Click(object sender, EventArgs e)
		{	Star1.Text="★";
			Star2.Text="★";
			Star3.Text="☆";
			Star4.Text="☆";
			Star5.Text="☆";
			Rating="★★☆☆☆";
		}
		public void Star3Click(object sender, EventArgs e)
		{	Star1.Text="★";
			Star2.Text="★";
			Star3.Text="★";
			Star4.Text="☆";
			Star5.Text="☆";
			Rating="★★★☆☆";
		}
		public void Star4Click(object sender, EventArgs e)
		{	Star1.Text="★";
			Star2.Text="★";
			Star3.Text="★";
			Star4.Text="★";
			Star5.Text="☆";
			Rating="★★★★☆";
		}
		public void Star5Click(object sender, EventArgs e)
		{	Star1.Text="★";
			Star2.Text="★";
			Star3.Text="★";
			Star4.Text="★";
			Star5.Text="★";
			Rating="★★★★★";
        }
	}
}
