namespace SmartVocabularyBook.src.gui
{
    partial class UserModification
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxSelectLanguage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAnyLanguage = new System.Windows.Forms.TextBox();
            this.btnConfirmMainLanguage = new System.Windows.Forms.Button();
            this.lConfirmedMainLanguage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mtbxNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.mtbxConfirmNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lCurrentNickname = new System.Windows.Forms.Label();
            this.lCurrentLanguage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hier kannst du deine Muttersprache auswählen";
            // 
            // lbxSelectLanguage
            // 
            this.lbxSelectLanguage.FormattingEnabled = true;
            this.lbxSelectLanguage.Location = new System.Drawing.Point(47, 109);
            this.lbxSelectLanguage.Name = "lbxSelectLanguage";
            this.lbxSelectLanguage.Size = new System.Drawing.Size(227, 95);
            this.lbxSelectLanguage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "oder eine beliebige verwenden";
            // 
            // tbxAnyLanguage
            // 
            this.tbxAnyLanguage.Location = new System.Drawing.Point(47, 242);
            this.tbxAnyLanguage.MaxLength = 50;
            this.tbxAnyLanguage.Name = "tbxAnyLanguage";
            this.tbxAnyLanguage.Size = new System.Drawing.Size(227, 20);
            this.tbxAnyLanguage.TabIndex = 3;
            this.tbxAnyLanguage.TextChanged += new System.EventHandler(this.tbxAnyLanguage_TextChanged);
            // 
            // btnConfirmMainLanguage
            // 
            this.btnConfirmMainLanguage.Location = new System.Drawing.Point(47, 285);
            this.btnConfirmMainLanguage.Name = "btnConfirmMainLanguage";
            this.btnConfirmMainLanguage.Size = new System.Drawing.Size(227, 44);
            this.btnConfirmMainLanguage.TabIndex = 4;
            this.btnConfirmMainLanguage.Text = "Muttersprache bestätigen";
            this.btnConfirmMainLanguage.UseVisualStyleBackColor = true;
            // 
            // lConfirmedMainLanguage
            // 
            this.lConfirmedMainLanguage.AutoSize = true;
            this.lConfirmedMainLanguage.Location = new System.Drawing.Point(44, 367);
            this.lConfirmedMainLanguage.Name = "lConfirmedMainLanguage";
            this.lConfirmedMainLanguage.Size = new System.Drawing.Size(105, 13);
            this.lConfirmedMainLanguage.TabIndex = 5;
            this.lConfirmedMainLanguage.Text = "Confirmed Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Erstelle dir einen Nickname";
            // 
            // tbxNickname
            // 
            this.tbxNickname.Location = new System.Drawing.Point(347, 125);
            this.tbxNickname.Name = "tbxNickname";
            this.tbxNickname.Size = new System.Drawing.Size(132, 20);
            this.tbxNickname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Möchtest du ein Passwort verwenden?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(644, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "ja (wenn ein Haken gesetzt wurde)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mtbxNewPassword
            // 
            this.mtbxNewPassword.Location = new System.Drawing.Point(644, 158);
            this.mtbxNewPassword.Name = "mtbxNewPassword";
            this.mtbxNewPassword.PasswordChar = '*';
            this.mtbxNewPassword.Size = new System.Drawing.Size(188, 20);
            this.mtbxNewPassword.TabIndex = 10;
            this.mtbxNewPassword.UseSystemPasswordChar = true;
            // 
            // mtbxConfirmNewPassword
            // 
            this.mtbxConfirmNewPassword.Location = new System.Drawing.Point(644, 184);
            this.mtbxConfirmNewPassword.Name = "mtbxConfirmNewPassword";
            this.mtbxConfirmNewPassword.Size = new System.Drawing.Size(188, 20);
            this.mtbxConfirmNewPassword.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lCurrentLanguage);
            this.groupBox1.Controls.Add(this.lCurrentNickname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(234, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktuelle Daten auf einen Blick";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nickname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Muttersprache:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ausgesuchte Sprache";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(554, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Neues Passwort";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Passwort bestätigen";
            // 
            // lCurrentNickname
            // 
            this.lCurrentNickname.AutoSize = true;
            this.lCurrentNickname.Location = new System.Drawing.Point(91, 28);
            this.lCurrentNickname.Name = "lCurrentNickname";
            this.lCurrentNickname.Size = new System.Drawing.Size(53, 13);
            this.lCurrentNickname.TabIndex = 16;
            this.lCurrentNickname.Text = "nickname";
            // 
            // lCurrentLanguage
            // 
            this.lCurrentLanguage.AutoSize = true;
            this.lCurrentLanguage.Location = new System.Drawing.Point(91, 53);
            this.lCurrentLanguage.Name = "lCurrentLanguage";
            this.lCurrentLanguage.Size = new System.Drawing.Size(77, 13);
            this.lCurrentLanguage.TabIndex = 17;
            this.lCurrentLanguage.Text = "mainLanguage";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "Speichern und Zurück";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(47, 413);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(137, 62);
            this.btnAbort.TabIndex = 17;
            this.btnAbort.Text = "Abbrechen";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nutzereinstellungen ";
            // 
            // UserModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtbxConfirmNewPassword);
            this.Controls.Add(this.mtbxNewPassword);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxNickname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lConfirmedMainLanguage);
            this.Controls.Add(this.btnConfirmMainLanguage);
            this.Controls.Add(this.tbxAnyLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxSelectLanguage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModification";
            this.Text = "UserModification";
            this.Load += new System.EventHandler(this.gr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxSelectLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAnyLanguage;
        private System.Windows.Forms.Button btnConfirmMainLanguage;
        private System.Windows.Forms.Label lConfirmedMainLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox mtbxNewPassword;
        private System.Windows.Forms.MaskedTextBox mtbxConfirmNewPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lCurrentLanguage;
        private System.Windows.Forms.Label lCurrentNickname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label label10;
    }
}