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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClearEntries = new System.Windows.Forms.Button();
            this.btnAddVocabulary = new System.Windows.Forms.Button();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.tbxSecondLang = new System.Windows.Forms.TextBox();
            this.tbxMainLang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewAllVocab = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OliveDrab;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vokabeln bearbeiten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "HIER WERDEN VOKABELN BEARBEITET";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClearEntries);
            this.tabPage3.Controls.Add(this.btnAddVocabulary);
            this.tabPage3.Controls.Add(this.tbxNote);
            this.tabPage3.Controls.Add(this.tbxSecondLang);
            this.tabPage3.Controls.Add(this.tbxMainLang);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(890, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Neue Vokabeln hinzufügen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClearEntries
            // 
            this.btnClearEntries.Location = new System.Drawing.Point(52, 200);
            this.btnClearEntries.Name = "btnClearEntries";
            this.btnClearEntries.Size = new System.Drawing.Size(99, 38);
            this.btnClearEntries.TabIndex = 5;
            this.btnClearEntries.Text = "Eingabe verwerfen";
            this.btnClearEntries.UseVisualStyleBackColor = true;
            this.btnClearEntries.Click += new System.EventHandler(this.btnClearEntries_Click);
            // 
            // btnAddVocabulary
            // 
            this.btnAddVocabulary.Location = new System.Drawing.Point(181, 200);
            this.btnAddVocabulary.Name = "btnAddVocabulary";
            this.btnAddVocabulary.Size = new System.Drawing.Size(99, 38);
            this.btnAddVocabulary.TabIndex = 4;
            this.btnAddVocabulary.Text = "Vokabeln hinzufügen";
            this.btnAddVocabulary.UseVisualStyleBackColor = true;
            this.btnAddVocabulary.Click += new System.EventHandler(this.btnAddVocabulary_Click);
            // 
            // tbxNote
            // 
            this.tbxNote.Location = new System.Drawing.Point(123, 164);
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Size = new System.Drawing.Size(157, 20);
            this.tbxNote.TabIndex = 3;
            // 
            // tbxSecondLang
            // 
            this.tbxSecondLang.Location = new System.Drawing.Point(123, 133);
            this.tbxSecondLang.Name = "tbxSecondLang";
            this.tbxSecondLang.Size = new System.Drawing.Size(157, 20);
            this.tbxSecondLang.TabIndex = 2;
            // 
            // tbxMainLang
            // 
            this.tbxMainLang.Location = new System.Drawing.Point(123, 97);
            this.tbxMainLang.Name = "tbxMainLang";
            this.tbxMainLang.Size = new System.Drawing.Size(157, 20);
            this.tbxMainLang.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Notiz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Übersetzung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hauptsprache";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "HIER WERDEN NEUE VOKABELN HINZUGEFÜGT";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(890, 473);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Test/ Übung";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "HIER KANN MAN SEINE VOKABELN ÜBEN";
            // 
            // listViewAllVocab
            // 
            this.listViewAllVocab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewAllVocab.Location = new System.Drawing.Point(7, 6);
            this.listViewAllVocab.Name = "listViewAllVocab";
            this.listViewAllVocab.Size = new System.Drawing.Size(772, 397);
            this.listViewAllVocab.TabIndex = 3;
            this.listViewAllVocab.UseCompatibleStateImageBehavior = false;
            this.listViewAllVocab.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sprache 1";
            this.columnHeader1.Width = 166;
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
    }
}