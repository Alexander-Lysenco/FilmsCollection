/*
 * Created by SharpDevelop.
 * User: LinJay
 * Date: 07.08.2015
 * Time: 0:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Коллекция_фильмов
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ListView FilmsCollection;
		private System.Windows.Forms.Button AddFilmButton;
		private System.Windows.Forms.Button EditFilmButton;
		private System.Windows.Forms.Button RemoveFilmButton;
		private System.Windows.Forms.GroupBox FilmInformationGB;
		private System.Windows.Forms.PictureBox SimpleLogo;
		private System.Windows.Forms.MenuStrip MainMenu;
		public System.Windows.Forms.ColumnHeader FilmName;
		public System.Windows.Forms.ColumnHeader FilmAddedDate;
		public System.Windows.Forms.ColumnHeader FilmRating;
		public System.Windows.Forms.ColumnHeader FilmComment;
		private System.Windows.Forms.Label HintFilmCommentLabel;
		private System.Windows.Forms.Label FilmAddedDateLabel;
		private System.Windows.Forms.Label HintFilmAddedDateLabel;
		public System.Windows.Forms.Label FilmNameLabel;
		private System.Windows.Forms.Label HintFilmNameLabel;
		private System.Windows.Forms.Label WelcomeLabel;
		private System.Windows.Forms.Label CurrentModeLabel;
		private System.Windows.Forms.Label FilmRatingLabel;
		private System.Windows.Forms.Label ModifyCollectionInfoLabel;
		private System.Windows.Forms.Label FilmsQuantityInfoLabel;
		private System.Windows.Forms.ToolStripMenuItem FileTollSMI;
		private System.Windows.Forms.ToolStripMenuItem CloseAppTSMI;
		private System.Windows.Forms.ToolStripMenuItem ModeTSMI;
		private System.Windows.Forms.ToolStripMenuItem TimeTableModeTSMI;
		private System.Windows.Forms.ToolStripMenuItem ReviewModeTSMI;
		private System.Windows.Forms.ToolStripMenuItem HelpTSMI;
		private System.Windows.Forms.ToolStripMenuItem AuthorsProfileTSMI;
		private System.Windows.Forms.ToolStripMenuItem FindInGoogleTSMI;
		private System.Windows.Forms.TextBox FilmCommentTB;
		private System.Windows.Forms.ToolStripMenuItem CopyTheHeaderCMS;
		private System.Windows.Forms.ContextMenuStrip ContextMenuBlock;
		private System.Windows.Forms.ToolStripMenuItem AboutTSMI;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.FilmsCollection = new System.Windows.Forms.ListView();
			this.FilmName = new System.Windows.Forms.ColumnHeader();
			this.FilmAddedDate = new System.Windows.Forms.ColumnHeader();
			this.FilmRating = new System.Windows.Forms.ColumnHeader();
			this.FilmComment = new System.Windows.Forms.ColumnHeader();
			this.ContextMenuBlock = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyTheHeaderCMS = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFilmButton = new System.Windows.Forms.Button();
			this.EditFilmButton = new System.Windows.Forms.Button();
			this.RemoveFilmButton = new System.Windows.Forms.Button();
			this.FilmInformationGB = new System.Windows.Forms.GroupBox();
			this.FilmCommentTB = new System.Windows.Forms.TextBox();
			this.HintFilmCommentLabel = new System.Windows.Forms.Label();
			this.FilmRatingLabel = new System.Windows.Forms.Label();
			this.FilmAddedDateLabel = new System.Windows.Forms.Label();
			this.HintFilmAddedDateLabel = new System.Windows.Forms.Label();
			this.FilmNameLabel = new System.Windows.Forms.Label();
			this.HintFilmNameLabel = new System.Windows.Forms.Label();
			this.SimpleLogo = new System.Windows.Forms.PictureBox();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.FileTollSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseAppTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ModeTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.TimeTableModeTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.ReviewModeTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.AuthorsProfileTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.FindInGoogleTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.WelcomeLabel = new System.Windows.Forms.Label();
			this.CurrentModeLabel = new System.Windows.Forms.Label();
			this.ModifyCollectionInfoLabel = new System.Windows.Forms.Label();
			this.FilmsQuantityInfoLabel = new System.Windows.Forms.Label();
			this.ContextMenuBlock.SuspendLayout();
			this.FilmInformationGB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SimpleLogo)).BeginInit();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// FilmsCollection
			// 
			this.FilmsCollection.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.FilmsCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.FilmsCollection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.FilmName,
			this.FilmAddedDate,
			this.FilmRating,
			this.FilmComment});
			this.FilmsCollection.ContextMenuStrip = this.ContextMenuBlock;
			this.FilmsCollection.FullRowSelect = true;
			this.FilmsCollection.GridLines = true;
			this.FilmsCollection.LabelWrap = false;
			this.FilmsCollection.Location = new System.Drawing.Point(474, 27);
			this.FilmsCollection.MultiSelect = false;
			this.FilmsCollection.Name = "FilmsCollection";
			this.FilmsCollection.ShowGroups = false;
			this.FilmsCollection.ShowItemToolTips = true;
			this.FilmsCollection.Size = new System.Drawing.Size(528, 559);
			this.FilmsCollection.TabIndex = 3;
			this.FilmsCollection.TabStop = false;
			this.FilmsCollection.UseCompatibleStateImageBehavior = false;
			this.FilmsCollection.View = System.Windows.Forms.View.Details;
			this.FilmsCollection.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.FilmsCollectionColumnClick);
			this.FilmsCollection.ItemActivate += new System.EventHandler(this.FilmsCollectionItemActivate);
			this.FilmsCollection.SelectedIndexChanged += new System.EventHandler(this.FilmsCollectionSelectedIndexChanged);
			// 
			// FilmName
			// 
			this.FilmName.Text = "Название фильма";
			this.FilmName.Width = 200;
			// 
			// FilmAddedDate
			// 
			this.FilmAddedDate.Text = "Дата просмотра";
			this.FilmAddedDate.Width = 115;
			// 
			// FilmRating
			// 
			this.FilmRating.Text = "Оценка";
			this.FilmRating.Width = 72;
			// 
			// FilmComment
			// 
			this.FilmComment.Text = "Рецензия для фильма";
			this.FilmComment.Width = 470;
			// 
			// ContextMenuBlock
			// 
			this.ContextMenuBlock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CopyTheHeaderCMS});
			this.ContextMenuBlock.Name = "ContextMenu";
			this.ContextMenuBlock.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.ContextMenuBlock.Size = new System.Drawing.Size(240, 26);
			this.ContextMenuBlock.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuBlockOpening);
			// 
			// CopyTheHeaderCMS
			// 
			this.CopyTheHeaderCMS.Name = "CopyTheHeaderCMS";
			this.CopyTheHeaderCMS.Size = new System.Drawing.Size(239, 22);
			this.CopyTheHeaderCMS.Text = "Копировать название фильма";
			this.CopyTheHeaderCMS.Click += new System.EventHandler(this.CopyTheHeaderCMSClick);
			// 
			// AddFilmButton
			// 
			this.AddFilmButton.Location = new System.Drawing.Point(12, 270);
			this.AddFilmButton.Name = "AddFilmButton";
			this.AddFilmButton.Size = new System.Drawing.Size(146, 23);
			this.AddFilmButton.TabIndex = 0;
			this.AddFilmButton.Text = "Добавить фильм";
			this.AddFilmButton.UseVisualStyleBackColor = true;
			this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButtonClick);
			// 
			// EditFilmButton
			// 
			this.EditFilmButton.Location = new System.Drawing.Point(170, 270);
			this.EditFilmButton.Name = "EditFilmButton";
			this.EditFilmButton.Size = new System.Drawing.Size(146, 23);
			this.EditFilmButton.TabIndex = 1;
			this.EditFilmButton.Text = "Редактировать";
			this.EditFilmButton.UseVisualStyleBackColor = true;
			this.EditFilmButton.Click += new System.EventHandler(this.EditFilmButtonClick);
			// 
			// RemoveFilmButton
			// 
			this.RemoveFilmButton.Location = new System.Drawing.Point(322, 270);
			this.RemoveFilmButton.Name = "RemoveFilmButton";
			this.RemoveFilmButton.Size = new System.Drawing.Size(146, 23);
			this.RemoveFilmButton.TabIndex = 2;
			this.RemoveFilmButton.Text = "Удалить фильм";
			this.RemoveFilmButton.UseVisualStyleBackColor = true;
			this.RemoveFilmButton.Click += new System.EventHandler(this.RemoveFilmButtonClick);
			// 
			// FilmInformationGB
			// 
			this.FilmInformationGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.FilmInformationGB.Controls.Add(this.FilmCommentTB);
			this.FilmInformationGB.Controls.Add(this.HintFilmCommentLabel);
			this.FilmInformationGB.Controls.Add(this.FilmRatingLabel);
			this.FilmInformationGB.Controls.Add(this.FilmAddedDateLabel);
			this.FilmInformationGB.Controls.Add(this.HintFilmAddedDateLabel);
			this.FilmInformationGB.Controls.Add(this.FilmNameLabel);
			this.FilmInformationGB.Controls.Add(this.HintFilmNameLabel);
			this.FilmInformationGB.Location = new System.Drawing.Point(12, 299);
			this.FilmInformationGB.Name = "FilmInformationGB";
			this.FilmInformationGB.Size = new System.Drawing.Size(456, 287);
			this.FilmInformationGB.TabIndex = 0;
			this.FilmInformationGB.TabStop = false;
			this.FilmInformationGB.Text = "Информация о выделенном фильме";
			// 
			// FilmCommentTB
			// 
			this.FilmCommentTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.FilmCommentTB.BackColor = System.Drawing.SystemColors.Control;
			this.FilmCommentTB.ForeColor = System.Drawing.Color.Blue;
			this.FilmCommentTB.Location = new System.Drawing.Point(7, 88);
			this.FilmCommentTB.MaxLength = 2000;
			this.FilmCommentTB.Multiline = true;
			this.FilmCommentTB.Name = "FilmCommentTB";
			this.FilmCommentTB.ReadOnly = true;
			this.FilmCommentTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.FilmCommentTB.Size = new System.Drawing.Size(443, 193);
			this.FilmCommentTB.TabIndex = 0;
			this.FilmCommentTB.TabStop = false;
			// 
			// HintFilmCommentLabel
			// 
			this.HintFilmCommentLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.HintFilmCommentLabel.Location = new System.Drawing.Point(7, 69);
			this.HintFilmCommentLabel.Name = "HintFilmCommentLabel";
			this.HintFilmCommentLabel.Size = new System.Drawing.Size(154, 15);
			this.HintFilmCommentLabel.TabIndex = 0;
			this.HintFilmCommentLabel.Text = "Комментарий к фильму:";
			// 
			// FilmRatingLabel
			// 
			this.FilmRatingLabel.BackColor = System.Drawing.Color.Transparent;
			this.FilmRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FilmRatingLabel.ForeColor = System.Drawing.Color.Gold;
			this.FilmRatingLabel.Location = new System.Drawing.Point(350, 59);
			this.FilmRatingLabel.Name = "FilmRatingLabel";
			this.FilmRatingLabel.Size = new System.Drawing.Size(100, 26);
			this.FilmRatingLabel.TabIndex = 0;
			this.FilmRatingLabel.Text = "★★★☆☆";
			this.FilmRatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FilmAddedDateLabel
			// 
			this.FilmAddedDateLabel.Location = new System.Drawing.Point(350, 46);
			this.FilmAddedDateLabel.Name = "FilmAddedDateLabel";
			this.FilmAddedDateLabel.Size = new System.Drawing.Size(100, 13);
			this.FilmAddedDateLabel.TabIndex = 0;
			this.FilmAddedDateLabel.Text = "Сегодня";
			this.FilmAddedDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// HintFilmAddedDateLabel
			// 
			this.HintFilmAddedDateLabel.Location = new System.Drawing.Point(7, 46);
			this.HintFilmAddedDateLabel.Name = "HintFilmAddedDateLabel";
			this.HintFilmAddedDateLabel.Size = new System.Drawing.Size(100, 13);
			this.HintFilmAddedDateLabel.TabIndex = 0;
			this.HintFilmAddedDateLabel.Text = "Дата добавления:";
			this.HintFilmAddedDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FilmNameLabel
			// 
			this.FilmNameLabel.ForeColor = System.Drawing.Color.Blue;
			this.FilmNameLabel.Location = new System.Drawing.Point(135, 15);
			this.FilmNameLabel.Name = "FilmNameLabel";
			this.FilmNameLabel.Size = new System.Drawing.Size(315, 27);
			this.FilmNameLabel.TabIndex = 0;
			this.FilmNameLabel.Text = "Название выделенного фильма";
			this.FilmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// HintFilmNameLabel
			// 
			this.HintFilmNameLabel.Location = new System.Drawing.Point(7, 20);
			this.HintFilmNameLabel.Name = "HintFilmNameLabel";
			this.HintFilmNameLabel.Size = new System.Drawing.Size(108, 16);
			this.HintFilmNameLabel.TabIndex = 0;
			this.HintFilmNameLabel.Text = "Название фильма:";
			this.HintFilmNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SimpleLogo
			// 
			this.SimpleLogo.Image = ((System.Drawing.Image)(resources.GetObject("SimpleLogo.Image")));
			this.SimpleLogo.Location = new System.Drawing.Point(12, 27);
			this.SimpleLogo.Name = "SimpleLogo";
			this.SimpleLogo.Size = new System.Drawing.Size(456, 92);
			this.SimpleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.SimpleLogo.TabIndex = 7;
			this.SimpleLogo.TabStop = false;
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.FileTollSMI,
			this.ModeTSMI,
			this.HelpTSMI});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.MainMenu.Size = new System.Drawing.Size(1014, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// FileTollSMI
			// 
			this.FileTollSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.CloseAppTSMI});
			this.FileTollSMI.Name = "FileTollSMI";
			this.FileTollSMI.Size = new System.Drawing.Size(48, 20);
			this.FileTollSMI.Text = "Файл";
			// 
			// CloseAppTSMI
			// 
			this.CloseAppTSMI.Name = "CloseAppTSMI";
			this.CloseAppTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.CloseAppTSMI.Size = new System.Drawing.Size(162, 22);
			this.CloseAppTSMI.Text = "Закрыть";
			this.CloseAppTSMI.Click += new System.EventHandler(this.CloseAppTSMIClick);
			// 
			// ModeTSMI
			// 
			this.ModeTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.TimeTableModeTSMI,
			this.ReviewModeTSMI});
			this.ModeTSMI.Name = "ModeTSMI";
			this.ModeTSMI.Size = new System.Drawing.Size(39, 20);
			this.ModeTSMI.Text = "Вид";
			// 
			// TimeTableModeTSMI
			// 
			this.TimeTableModeTSMI.Name = "TimeTableModeTSMI";
			this.TimeTableModeTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
			this.TimeTableModeTSMI.Size = new System.Drawing.Size(234, 22);
			this.TimeTableModeTSMI.Text = "Режим расписания";
			this.TimeTableModeTSMI.Click += new System.EventHandler(this.TimeTableModeTSMIClick);
			// 
			// ReviewModeTSMI
			// 
			this.ReviewModeTSMI.Name = "ReviewModeTSMI";
			this.ReviewModeTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
			this.ReviewModeTSMI.Size = new System.Drawing.Size(234, 22);
			this.ReviewModeTSMI.Text = "Режим рецензии";
			this.ReviewModeTSMI.Click += new System.EventHandler(this.ReviewModeTSMIClick);
			// 
			// HelpTSMI
			// 
			this.HelpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.AuthorsProfileTSMI,
			this.FindInGoogleTSMI,
			this.AboutTSMI});
			this.HelpTSMI.Name = "HelpTSMI";
			this.HelpTSMI.Size = new System.Drawing.Size(65, 20);
			this.HelpTSMI.Text = "Справка";
			// 
			// AuthorsProfileTSMI
			// 
			this.AuthorsProfileTSMI.Name = "AuthorsProfileTSMI";
			this.AuthorsProfileTSMI.Size = new System.Drawing.Size(236, 22);
			this.AuthorsProfileTSMI.Text = "Постетить ВК автора";
			this.AuthorsProfileTSMI.Click += new System.EventHandler(this.AuthorsProfileTSMIClick);
			// 
			// FindInGoogleTSMI
			// 
			this.FindInGoogleTSMI.Name = "FindInGoogleTSMI";
			this.FindInGoogleTSMI.Size = new System.Drawing.Size(236, 22);
			this.FindInGoogleTSMI.Text = "Поикать что-нибудь в Google";
			this.FindInGoogleTSMI.Click += new System.EventHandler(this.FindInGoogleTSMIClick);
			// 
			// AboutTSMI
			// 
			this.AboutTSMI.Name = "AboutTSMI";
			this.AboutTSMI.Size = new System.Drawing.Size(236, 22);
			this.AboutTSMI.Text = "О программе";
			this.AboutTSMI.Click += new System.EventHandler(this.AboutTSMIClick);
			// 
			// WelcomeLabel
			// 
			this.WelcomeLabel.Location = new System.Drawing.Point(12, 122);
			this.WelcomeLabel.Name = "WelcomeLabel";
			this.WelcomeLabel.Size = new System.Drawing.Size(456, 27);
			this.WelcomeLabel.TabIndex = 0;
			this.WelcomeLabel.Text = "Данная программа является менеджером информации о фильмах.\r\nСвоего рода персональ" +
	"ная фильмотека. Программа работает в двух режимах.";
			// 
			// CurrentModeLabel
			// 
			this.CurrentModeLabel.ForeColor = System.Drawing.Color.Blue;
			this.CurrentModeLabel.Location = new System.Drawing.Point(12, 160);
			this.CurrentModeLabel.Name = "CurrentModeLabel";
			this.CurrentModeLabel.Size = new System.Drawing.Size(456, 27);
			this.CurrentModeLabel.TabIndex = 0;
			this.CurrentModeLabel.Text = "В режиме рецензии Вы можете оставить ранее просмотренному Вами фильму оценку и не" +
	"большой отзыв.";
			// 
			// ModifyCollectionInfoLabel
			// 
			this.ModifyCollectionInfoLabel.Location = new System.Drawing.Point(12, 224);
			this.ModifyCollectionInfoLabel.Name = "ModifyCollectionInfoLabel";
			this.ModifyCollectionInfoLabel.Size = new System.Drawing.Size(456, 43);
			this.ModifyCollectionInfoLabel.TabIndex = 0;
			this.ModifyCollectionInfoLabel.Text = "Чтобы добавить фильм в коллекцию, нажмите кнопку \"Добавить\". Для редактирования и" +
	"ли удаления фильма сначала выделите его в коллекции, а затем нажмите соответству" +
	"ющую кнопку.";
			// 
			// FilmsQuantityInfoLabel
			// 
			this.FilmsQuantityInfoLabel.Location = new System.Drawing.Point(12, 196);
			this.FilmsQuantityInfoLabel.Name = "FilmsQuantityInfoLabel";
			this.FilmsQuantityInfoLabel.Size = new System.Drawing.Size(450, 17);
			this.FilmsQuantityInfoLabel.TabIndex = 0;
			this.FilmsQuantityInfoLabel.Text = "На текущий момент в коллекцию добавлено 0 фильмов.";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1014, 598);
			this.Controls.Add(this.FilmsQuantityInfoLabel);
			this.Controls.Add(this.ModifyCollectionInfoLabel);
			this.Controls.Add(this.CurrentModeLabel);
			this.Controls.Add(this.WelcomeLabel);
			this.Controls.Add(this.SimpleLogo);
			this.Controls.Add(this.FilmInformationGB);
			this.Controls.Add(this.RemoveFilmButton);
			this.Controls.Add(this.EditFilmButton);
			this.Controls.Add(this.AddFilmButton);
			this.Controls.Add(this.FilmsCollection);
			this.Controls.Add(this.MainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.Text = "Коллекция фильмов";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ContextMenuBlock.ResumeLayout(false);
			this.FilmInformationGB.ResumeLayout(false);
			this.FilmInformationGB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SimpleLogo)).EndInit();
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}