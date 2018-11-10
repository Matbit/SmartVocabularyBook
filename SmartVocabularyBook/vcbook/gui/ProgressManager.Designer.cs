namespace SmartVocabularyBook.vcbook.gui
{
    partial class ProgressManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewAllVocab = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbxChangeVocabulary = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxDataMemo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveWord = new System.Windows.Forms.Button();
            this.tbxDataMainLang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxDataSecondLang = new System.Windows.Forms.TextBox();
            this.grbxSerachVocabulry = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnArchived = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchWord = new System.Windows.Forms.Button();
            this.lbxDBResult = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.rbtnMainLang = new System.Windows.Forms.RadioButton();
            this.rbtnSecondLang = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.btnClearEntries = new System.Windows.Forms.Button();
            this.btnAddVocabulary = new System.Windows.Forms.Button();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.tbxSecondLang = new System.Windows.Forms.TextBox();
            this.tbxMainLang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.llClose = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grbxChangeVocabulary.SuspendLayout();
            this.grbxSerachVocabulry.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 499);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage1.Controls.Add(this.listViewAllVocab);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Übersicht";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // listViewAllVocab
            // 
            this.listViewAllVocab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewAllVocab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAllVocab.Location = new System.Drawing.Point(7, 6);
            this.listViewAllVocab.Name = "listViewAllVocab";
            this.listViewAllVocab.Size = new System.Drawing.Size(772, 397);
            this.listViewAllVocab.TabIndex = 3;
            this.listViewAllVocab.UseCompatibleStateImageBehavior = false;
            this.listViewAllVocab.View = System.Windows.Forms.View.Details;
            this.listViewAllVocab.SelectedIndexChanged += new System.EventHandler(this.listViewAllVocab_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sprache 1";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sprache 2";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Notiz";
            this.columnHeader3.Width = 203;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Khaki;
            this.tabPage2.Controls.Add(this.grbxChangeVocabulary);
            this.tabPage2.Controls.Add(this.grbxSerachVocabulry);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vokabeln bearbeiten";
            // 
            // grbxChangeVocabulary
            // 
            this.grbxChangeVocabulary.Controls.Add(this.label10);
            this.grbxChangeVocabulary.Controls.Add(this.tbxDataMemo);
            this.grbxChangeVocabulary.Controls.Add(this.label1);
            this.grbxChangeVocabulary.Controls.Add(this.btnSaveWord);
            this.grbxChangeVocabulary.Controls.Add(this.tbxDataMainLang);
            this.grbxChangeVocabulary.Controls.Add(this.label8);
            this.grbxChangeVocabulary.Controls.Add(this.tbxDataSecondLang);
            this.grbxChangeVocabulary.Location = new System.Drawing.Point(471, 58);
            this.grbxChangeVocabulary.Name = "grbxChangeVocabulary";
            this.grbxChangeVocabulary.Size = new System.Drawing.Size(384, 254);
            this.grbxChangeVocabulary.TabIndex = 13;
            this.grbxChangeVocabulary.TabStop = false;
            this.grbxChangeVocabulary.Text = "Änderungen vornehmen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Notiz";
            // 
            // tbxDataMemo
            // 
            this.tbxDataMemo.Location = new System.Drawing.Point(9, 124);
            this.tbxDataMemo.MaxLength = 120;
            this.tbxDataMemo.Name = "tbxDataMemo";
            this.tbxDataMemo.Size = new System.Drawing.Size(349, 20);
            this.tbxDataMemo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hauptsprache";
            // 
            // btnSaveWord
            // 
            this.btnSaveWord.Location = new System.Drawing.Point(216, 197);
            this.btnSaveWord.Name = "btnSaveWord";
            this.btnSaveWord.Size = new System.Drawing.Size(162, 51);
            this.btnSaveWord.TabIndex = 12;
            this.btnSaveWord.Text = "Änderungen Speichern";
            this.btnSaveWord.UseVisualStyleBackColor = true;
            this.btnSaveWord.Click += new System.EventHandler(this.btnSaveWord_Click);
            // 
            // tbxDataMainLang
            // 
            this.tbxDataMainLang.Location = new System.Drawing.Point(9, 67);
            this.tbxDataMainLang.MaxLength = 50;
            this.tbxDataMainLang.Name = "tbxDataMainLang";
            this.tbxDataMainLang.Size = new System.Drawing.Size(162, 20);
            this.tbxDataMainLang.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Übersetzung";
            // 
            // tbxDataSecondLang
            // 
            this.tbxDataSecondLang.Location = new System.Drawing.Point(196, 67);
            this.tbxDataSecondLang.MaxLength = 50;
            this.tbxDataSecondLang.Name = "tbxDataSecondLang";
            this.tbxDataSecondLang.Size = new System.Drawing.Size(162, 20);
            this.tbxDataSecondLang.TabIndex = 10;
            // 
            // grbxSerachVocabulry
            // 
            this.grbxSerachVocabulry.Controls.Add(this.label9);
            this.grbxSerachVocabulry.Controls.Add(this.btnArchived);
            this.grbxSerachVocabulry.Controls.Add(this.btnDelete);
            this.grbxSerachVocabulry.Controls.Add(this.btnSearchWord);
            this.grbxSerachVocabulry.Controls.Add(this.lbxDBResult);
            this.grbxSerachVocabulry.Controls.Add(this.tbxSearch);
            this.grbxSerachVocabulry.Controls.Add(this.rbtnMainLang);
            this.grbxSerachVocabulry.Controls.Add(this.rbtnSecondLang);
            this.grbxSerachVocabulry.Location = new System.Drawing.Point(19, 29);
            this.grbxSerachVocabulry.Name = "grbxSerachVocabulry";
            this.grbxSerachVocabulry.Size = new System.Drawing.Size(337, 407);
            this.grbxSerachVocabulry.TabIndex = 3;
            this.grbxSerachVocabulry.TabStop = false;
            this.grbxSerachVocabulry.Text = "Suche Vokabel nach";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Suche:";
            // 
            // btnArchived
            // 
            this.btnArchived.Location = new System.Drawing.Point(199, 349);
            this.btnArchived.Name = "btnArchived";
            this.btnArchived.Size = new System.Drawing.Size(112, 38);
            this.btnArchived.TabIndex = 7;
            this.btnArchived.Text = "Eintrag archivieren";
            this.btnArchived.UseVisualStyleBackColor = true;
            this.btnArchived.Click += new System.EventHandler(this.btnArchived_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eintrag Löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchWord
            // 
            this.btnSearchWord.Location = new System.Drawing.Point(199, 105);
            this.btnSearchWord.Name = "btnSearchWord";
            this.btnSearchWord.Size = new System.Drawing.Size(106, 23);
            this.btnSearchWord.TabIndex = 5;
            this.btnSearchWord.Text = "Suchen!";
            this.btnSearchWord.UseVisualStyleBackColor = true;
            this.btnSearchWord.Visible = false;
            this.btnSearchWord.Click += new System.EventHandler(this.btnSearchWord_Click);
            // 
            // lbxDBResult
            // 
            this.lbxDBResult.FormattingEnabled = true;
            this.lbxDBResult.Location = new System.Drawing.Point(6, 153);
            this.lbxDBResult.Name = "lbxDBResult";
            this.lbxDBResult.Size = new System.Drawing.Size(305, 173);
            this.lbxDBResult.TabIndex = 4;
            this.lbxDBResult.SelectedIndexChanged += new System.EventHandler(this.lbxDBResult_SelectedIndexChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(6, 107);
            this.tbxSearch.MaxLength = 50;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(162, 20);
            this.tbxSearch.TabIndex = 3;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // rbtnMainLang
            // 
            this.rbtnMainLang.AutoSize = true;
            this.rbtnMainLang.Checked = true;
            this.rbtnMainLang.Location = new System.Drawing.Point(6, 29);
            this.rbtnMainLang.Name = "rbtnMainLang";
            this.rbtnMainLang.Size = new System.Drawing.Size(92, 17);
            this.rbtnMainLang.TabIndex = 1;
            this.rbtnMainLang.TabStop = true;
            this.rbtnMainLang.Text = "Hauptsprache";
            this.rbtnMainLang.UseVisualStyleBackColor = true;
            // 
            // rbtnSecondLang
            // 
            this.rbtnSecondLang.AutoSize = true;
            this.rbtnSecondLang.Location = new System.Drawing.Point(6, 52);
            this.rbtnSecondLang.Name = "rbtnSecondLang";
            this.rbtnSecondLang.Size = new System.Drawing.Size(85, 17);
            this.rbtnSecondLang.TabIndex = 2;
            this.rbtnSecondLang.TabStop = true;
            this.rbtnSecondLang.Text = "Übersetzung";
            this.rbtnSecondLang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "HIER WERDEN VOKABELN BEARBEITET";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.llClose);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.browser);
            this.tabPage3.Controls.Add(this.btnClearEntries);
            this.tabPage3.Controls.Add(this.btnAddVocabulary);
            this.tabPage3.Controls.Add(this.tbxNote);
            this.tabPage3.Controls.Add(this.tbxSecondLang);
            this.tabPage3.Controls.Add(this.tbxMainLang);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(890, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Neue Vokabeln hinzufügen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(161, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "im Web suchen..";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOpenBrowser_LinkClicked);
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(257, 12);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            this.browser.Size = new System.Drawing.Size(630, 453);
            this.browser.TabIndex = 0;
            this.browser.WebBrowserShortcutsEnabled = false;
            // 
            // btnClearEntries
            // 
            this.btnClearEntries.Location = new System.Drawing.Point(57, 141);
            this.btnClearEntries.Name = "btnClearEntries";
            this.btnClearEntries.Size = new System.Drawing.Size(81, 38);
            this.btnClearEntries.TabIndex = 5;
            this.btnClearEntries.Text = "Eingabe verwerfen";
            this.btnClearEntries.UseVisualStyleBackColor = true;
            this.btnClearEntries.Click += new System.EventHandler(this.btnClearEntries_Click);
            // 
            // btnAddVocabulary
            // 
            this.btnAddVocabulary.Location = new System.Drawing.Point(167, 141);
            this.btnAddVocabulary.Name = "btnAddVocabulary";
            this.btnAddVocabulary.Size = new System.Drawing.Size(81, 38);
            this.btnAddVocabulary.TabIndex = 4;
            this.btnAddVocabulary.Text = "Vokabeln hinzufügen";
            this.btnAddVocabulary.UseVisualStyleBackColor = true;
            this.btnAddVocabulary.Click += new System.EventHandler(this.btnAddVocabulary_Click);
            // 
            // tbxNote
            // 
            this.tbxNote.Location = new System.Drawing.Point(91, 104);
            this.tbxNote.MaxLength = 100;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Size = new System.Drawing.Size(157, 20);
            this.tbxNote.TabIndex = 3;
            // 
            // tbxSecondLang
            // 
            this.tbxSecondLang.Location = new System.Drawing.Point(91, 70);
            this.tbxSecondLang.MaxLength = 50;
            this.tbxSecondLang.Name = "tbxSecondLang";
            this.tbxSecondLang.Size = new System.Drawing.Size(157, 20);
            this.tbxSecondLang.TabIndex = 2;
            // 
            // tbxMainLang
            // 
            this.tbxMainLang.Location = new System.Drawing.Point(91, 38);
            this.tbxMainLang.MaxLength = 50;
            this.tbxMainLang.Name = "tbxMainLang";
            this.tbxMainLang.Size = new System.Drawing.Size(157, 20);
            this.tbxMainLang.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Notiz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Übersetzung*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hauptsprache*";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(890, 473);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Test/ Übung";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 283);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "HIER KANN MAN SEINE VOKABELN ÜBEN";
            // 
            // llClose
            // 
            this.llClose.AutoSize = true;
            this.llClose.Location = new System.Drawing.Point(183, 452);
            this.llClose.Name = "llClose";
            this.llClose.Size = new System.Drawing.Size(68, 13);
            this.llClose.TabIndex = 7;
            this.llClose.TabStop = true;
            this.llClose.Text = "ausblenden..";
            this.llClose.Visible = false;
            this.llClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClose_LinkClicked);
            // 
            // ProgressManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grbxChangeVocabulary.ResumeLayout(false);
            this.grbxChangeVocabulary.PerformLayout();
            this.grbxSerachVocabulry.ResumeLayout(false);
            this.grbxSerachVocabulry.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearEntries;
        private System.Windows.Forms.Button btnAddVocabulary;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.TextBox tbxSecondLang;
        private System.Windows.Forms.TextBox tbxMainLang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewAllVocab;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox grbxSerachVocabulry;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.RadioButton rbtnMainLang;
        private System.Windows.Forms.RadioButton rbtnSecondLang;
        private System.Windows.Forms.Button btnArchived;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchWord;
        private System.Windows.Forms.ListBox lbxDBResult;
        private System.Windows.Forms.GroupBox grbxChangeVocabulary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveWord;
        private System.Windows.Forms.TextBox tbxDataMainLang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxDataSecondLang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxDataMemo;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel llClose;
    }
}