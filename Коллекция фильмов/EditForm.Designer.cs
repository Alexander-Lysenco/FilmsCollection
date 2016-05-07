/*
 * Created by SharpDevelop.
 * User: LinJay
 * Date: 07.08.2015
 * Time: 3:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Коллекция_фильмов
{
	partial class EditForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		public System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button EditSaveButton;
		private System.Windows.Forms.Button EditCancelButton;
		public System.Windows.Forms.TextBox EditFilmNameTB;
		public System.Windows.Forms.DateTimePicker EditFilmAddedDate;
		public System.Windows.Forms.TextBox EditFilmCommentTB;
		private System.Windows.Forms.Label EditFilmNameLabel;
		public System.Windows.Forms.Label EditFilmAddedDateLabel;
		public System.Windows.Forms.Label EditFilmRatingLabel;
		public System.Windows.Forms.Label EditFilmCommentLabel;
		private System.Windows.Forms.Label Star1;
		private System.Windows.Forms.Label Star5;
		private System.Windows.Forms.Label Star2;
		private System.Windows.Forms.Label Star3;
		private System.Windows.Forms.Label Star4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.EditSaveButton = new System.Windows.Forms.Button();
			this.EditCancelButton = new System.Windows.Forms.Button();
			this.EditFilmNameTB = new System.Windows.Forms.TextBox();
			this.EditFilmAddedDate = new System.Windows.Forms.DateTimePicker();
			this.EditFilmCommentTB = new System.Windows.Forms.TextBox();
			this.EditFilmNameLabel = new System.Windows.Forms.Label();
			this.EditFilmAddedDateLabel = new System.Windows.Forms.Label();
			this.EditFilmRatingLabel = new System.Windows.Forms.Label();
			this.EditFilmCommentLabel = new System.Windows.Forms.Label();
			this.Star1 = new System.Windows.Forms.Label();
			this.Star5 = new System.Windows.Forms.Label();
			this.Star2 = new System.Windows.Forms.Label();
			this.Star3 = new System.Windows.Forms.Label();
			this.Star4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// EditSaveButton
			// 
			this.EditSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.EditSaveButton.Location = new System.Drawing.Point(12, 331);
			this.EditSaveButton.Name = "EditSaveButton";
			this.EditSaveButton.Size = new System.Drawing.Size(176, 23);
			this.EditSaveButton.TabIndex = 4;
			this.EditSaveButton.Text = "Сохранить";
			this.EditSaveButton.UseVisualStyleBackColor = true;
			this.EditSaveButton.Click += new System.EventHandler(this.EditSaveButtonClick);
			// 
			// EditCancelButton
			// 
			this.EditCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.EditCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.EditCancelButton.Location = new System.Drawing.Point(197, 331);
			this.EditCancelButton.Name = "EditCancelButton";
			this.EditCancelButton.Size = new System.Drawing.Size(175, 23);
			this.EditCancelButton.TabIndex = 5;
			this.EditCancelButton.Text = "Отменить";
			this.EditCancelButton.UseVisualStyleBackColor = true;
			this.EditCancelButton.Click += new System.EventHandler(this.EditCancelButtonClick);
			// 
			// EditFilmNameTB
			// 
			this.EditFilmNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.EditFilmNameTB.Location = new System.Drawing.Point(118, 9);
			this.EditFilmNameTB.MaxLength = 100;
			this.EditFilmNameTB.Name = "EditFilmNameTB";
			this.EditFilmNameTB.Size = new System.Drawing.Size(254, 20);
			this.EditFilmNameTB.TabIndex = 1;
			// 
			// EditFilmAddedDate
			// 
			this.EditFilmAddedDate.Location = new System.Drawing.Point(228, 35);
			this.EditFilmAddedDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.EditFilmAddedDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
			this.EditFilmAddedDate.Name = "EditFilmAddedDate";
			this.EditFilmAddedDate.Size = new System.Drawing.Size(144, 20);
			this.EditFilmAddedDate.TabIndex = 2;
			this.EditFilmAddedDate.Value = new System.DateTime(2015, 8, 7, 16, 3, 20, 0);
			// 
			// EditFilmCommentTB
			// 
			this.EditFilmCommentTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.EditFilmCommentTB.Location = new System.Drawing.Point(12, 112);
			this.EditFilmCommentTB.MaxLength = 2000;
			this.EditFilmCommentTB.Multiline = true;
			this.EditFilmCommentTB.Name = "EditFilmCommentTB";
			this.EditFilmCommentTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.EditFilmCommentTB.Size = new System.Drawing.Size(360, 214);
			this.EditFilmCommentTB.TabIndex = 3;
			// 
			// EditFilmNameLabel
			// 
			this.EditFilmNameLabel.Location = new System.Drawing.Point(12, 9);
			this.EditFilmNameLabel.Name = "EditFilmNameLabel";
			this.EditFilmNameLabel.Size = new System.Drawing.Size(100, 20);
			this.EditFilmNameLabel.TabIndex = 0;
			this.EditFilmNameLabel.Text = "Название фильма";
			this.EditFilmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EditFilmAddedDateLabel
			// 
			this.EditFilmAddedDateLabel.Location = new System.Drawing.Point(12, 35);
			this.EditFilmAddedDateLabel.Name = "EditFilmAddedDateLabel";
			this.EditFilmAddedDateLabel.Size = new System.Drawing.Size(138, 20);
			this.EditFilmAddedDateLabel.TabIndex = 0;
			this.EditFilmAddedDateLabel.Text = "Дата просмотра (выхода)";
			this.EditFilmAddedDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EditFilmRatingLabel
			// 
			this.EditFilmRatingLabel.Location = new System.Drawing.Point(12, 65);
			this.EditFilmRatingLabel.Name = "EditFilmRatingLabel";
			this.EditFilmRatingLabel.Size = new System.Drawing.Size(151, 19);
			this.EditFilmRatingLabel.TabIndex = 0;
			this.EditFilmRatingLabel.Text = "Оценка фильма (приоритет)";
			this.EditFilmRatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EditFilmCommentLabel
			// 
			this.EditFilmCommentLabel.Location = new System.Drawing.Point(12, 84);
			this.EditFilmCommentLabel.Name = "EditFilmCommentLabel";
			this.EditFilmCommentLabel.Size = new System.Drawing.Size(159, 25);
			this.EditFilmCommentLabel.TabIndex = 0;
			this.EditFilmCommentLabel.Text = "Рецензия фильма (описание)";
			this.EditFilmCommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Star1
			// 
			this.Star1.BackColor = System.Drawing.Color.Transparent;
			this.Star1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Star1.ForeColor = System.Drawing.Color.Gold;
			this.Star1.Location = new System.Drawing.Point(270, 65);
			this.Star1.Margin = new System.Windows.Forms.Padding(0);
			this.Star1.Name = "Star1";
			this.Star1.Size = new System.Drawing.Size(25, 25);
			this.Star1.TabIndex = 0;
			this.Star1.Text = "☆";
			this.Star1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Star1.Click += new System.EventHandler(this.Star1Click);
			// 
			// Star5
			// 
			this.Star5.BackColor = System.Drawing.Color.Transparent;
			this.Star5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Star5.ForeColor = System.Drawing.Color.Gold;
			this.Star5.Location = new System.Drawing.Point(350, 65);
			this.Star5.Margin = new System.Windows.Forms.Padding(0);
			this.Star5.Name = "Star5";
			this.Star5.Size = new System.Drawing.Size(25, 25);
			this.Star5.TabIndex = 0;
			this.Star5.Text = "☆";
			this.Star5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Star5.Click += new System.EventHandler(this.Star5Click);
			// 
			// Star2
			// 
			this.Star2.BackColor = System.Drawing.Color.Transparent;
			this.Star2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Star2.ForeColor = System.Drawing.Color.Gold;
			this.Star2.Location = new System.Drawing.Point(290, 65);
			this.Star2.Margin = new System.Windows.Forms.Padding(0);
			this.Star2.Name = "Star2";
			this.Star2.Size = new System.Drawing.Size(25, 25);
			this.Star2.TabIndex = 0;
			this.Star2.Text = "☆";
			this.Star2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Star2.Click += new System.EventHandler(this.Star2Click);
			// 
			// Star3
			// 
			this.Star3.BackColor = System.Drawing.Color.Transparent;
			this.Star3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Star3.ForeColor = System.Drawing.Color.Gold;
			this.Star3.Location = new System.Drawing.Point(310, 65);
			this.Star3.Margin = new System.Windows.Forms.Padding(0);
			this.Star3.Name = "Star3";
			this.Star3.Size = new System.Drawing.Size(25, 25);
			this.Star3.TabIndex = 0;
			this.Star3.Text = "☆";
			this.Star3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Star3.Click += new System.EventHandler(this.Star3Click);
			// 
			// Star4
			// 
			this.Star4.BackColor = System.Drawing.Color.Transparent;
			this.Star4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Star4.ForeColor = System.Drawing.Color.Gold;
			this.Star4.Location = new System.Drawing.Point(330, 65);
			this.Star4.Margin = new System.Windows.Forms.Padding(0);
			this.Star4.Name = "Star4";
			this.Star4.Size = new System.Drawing.Size(25, 25);
			this.Star4.TabIndex = 0;
			this.Star4.Text = "☆";
			this.Star4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Star4.Click += new System.EventHandler(this.Star4Click);
			// 
			// EditForm
			// 
			this.AcceptButton = this.EditSaveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.EditCancelButton;
			this.ClientSize = new System.Drawing.Size(384, 362);
			this.Controls.Add(this.Star5);
			this.Controls.Add(this.Star4);
			this.Controls.Add(this.Star3);
			this.Controls.Add(this.Star2);
			this.Controls.Add(this.Star1);
			this.Controls.Add(this.EditFilmCommentLabel);
			this.Controls.Add(this.EditFilmRatingLabel);
			this.Controls.Add(this.EditFilmAddedDateLabel);
			this.Controls.Add(this.EditFilmNameLabel);
			this.Controls.Add(this.EditFilmCommentTB);
			this.Controls.Add(this.EditFilmAddedDate);
			this.Controls.Add(this.EditFilmNameTB);
			this.Controls.Add(this.EditCancelButton);
			this.Controls.Add(this.EditSaveButton);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "EditForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Редактирование элемента";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditFormFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
