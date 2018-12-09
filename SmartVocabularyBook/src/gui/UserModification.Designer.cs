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
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNickname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lCurrentLanguage = new System.Windows.Forms.Label();
            this.lCurrentNickname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveUserData = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lbxSelectForeignLanguage = new System.Windows.Forms.ListBox();
            this.tbxAnyForeignLanguage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lCurrentForeignLanguage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wähle deine Muttersprache aus";
            // 
            // lbxSelectLanguage
            // 
            this.lbxSelectLanguage.BackColor = System.Drawing.Color.Snow;
            this.lbxSelectLanguage.FormattingEnabled = true;
            this.lbxSelectLanguage.Location = new System.Drawing.Point(29, 82);
            this.lbxSelectLanguage.Name = "lbxSelectLanguage";
            this.lbxSelectLanguage.Size = new System.Drawing.Size(227, 95);
            this.lbxSelectLanguage.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "oder eine beliebige verwenden";
            // 
            // tbxAnyLanguage
            // 
            this.tbxAnyLanguage.BackColor = System.Drawing.Color.Snow;
            this.tbxAnyLanguage.Location = new System.Drawing.Point(29, 208);
            this.tbxAnyLanguage.MaxLength = 50;
            this.tbxAnyLanguage.Name = "tbxAnyLanguage";
            this.tbxAnyLanguage.Size = new System.Drawing.Size(227, 20);
            this.tbxAnyLanguage.TabIndex = 3;
            this.tbxAnyLanguage.TextChanged += new System.EventHandler(this.tbxAnyLanguage_TextChanged);
            // 
            // btnConfirmMainLanguage
            // 
            this.btnConfirmMainLanguage.BackColor = System.Drawing.Color.Orange;
            this.btnConfirmMainLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmMainLanguage.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConfirmMainLanguage.Location = new System.Drawing.Point(371, 245);
            this.btnConfirmMainLanguage.Name = "btnConfirmMainLanguage";
            this.btnConfirmMainLanguage.Size = new System.Drawing.Size(227, 84);
            this.btnConfirmMainLanguage.TabIndex = 4;
            this.btnConfirmMainLanguage.Text = "Eingaben bestätigen";
            this.btnConfirmMainLanguage.UseVisualStyleBackColor = false;
            this.btnConfirmMainLanguage.Click += new System.EventHandler(this.btnConfirmMainLanguage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ändere deinen Nickname";
            // 
            // tbxNickname
            // 
            this.tbxNickname.BackColor = System.Drawing.Color.Snow;
            this.tbxNickname.Location = new System.Drawing.Point(29, 287);
            this.tbxNickname.MaxLength = 50;
            this.tbxNickname.Name = "tbxNickname";
            this.tbxNickname.Size = new System.Drawing.Size(168, 20);
            this.tbxNickname.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.groupBox1.Controls.Add(this.lCurrentForeignLanguage);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lCurrentLanguage);
            this.groupBox1.Controls.Add(this.lCurrentNickname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(613, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 125);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktuelle Daten auf einen Blick";
            // 
            // lCurrentLanguage
            // 
            this.lCurrentLanguage.AutoSize = true;
            this.lCurrentLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurrentLanguage.Location = new System.Drawing.Point(111, 53);
            this.lCurrentLanguage.Name = "lCurrentLanguage";
            this.lCurrentLanguage.Size = new System.Drawing.Size(98, 16);
            this.lCurrentLanguage.TabIndex = 17;
            this.lCurrentLanguage.Text = "mainLanguage";
            // 
            // lCurrentNickname
            // 
            this.lCurrentNickname.AutoSize = true;
            this.lCurrentNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurrentNickname.Location = new System.Drawing.Point(111, 28);
            this.lCurrentNickname.Name = "lCurrentNickname";
            this.lCurrentNickname.Size = new System.Drawing.Size(66, 16);
            this.lCurrentNickname.TabIndex = 16;
            this.lCurrentNickname.Text = "nickname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Muttersprache:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nickname:";
            // 
            // btnSaveUserData
            // 
            this.btnSaveUserData.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSaveUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUserData.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSaveUserData.Location = new System.Drawing.Point(751, 413);
            this.btnSaveUserData.Name = "btnSaveUserData";
            this.btnSaveUserData.Size = new System.Drawing.Size(137, 62);
            this.btnSaveUserData.TabIndex = 16;
            this.btnSaveUserData.Text = "Speichern und Zurück";
            this.btnSaveUserData.UseVisualStyleBackColor = false;
            this.btnSaveUserData.Click += new System.EventHandler(this.btnSaveUserData_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAbort.Location = new System.Drawing.Point(29, 413);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(137, 62);
            this.btnAbort.TabIndex = 17;
            this.btnAbort.Text = "Abbrechen";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nutzereinstellungen ";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteAccount.Location = new System.Drawing.Point(700, 23);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(188, 48);
            this.btnDeleteAccount.TabIndex = 19;
            this.btnDeleteAccount.Text = "Diesen Account löschen";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // lbxSelectForeignLanguage
            // 
            this.lbxSelectForeignLanguage.FormattingEnabled = true;
            this.lbxSelectForeignLanguage.Location = new System.Drawing.Point(371, 82);
            this.lbxSelectForeignLanguage.Name = "lbxSelectForeignLanguage";
            this.lbxSelectForeignLanguage.Size = new System.Drawing.Size(227, 95);
            this.lbxSelectForeignLanguage.TabIndex = 20;
            // 
            // tbxAnyForeignLanguage
            // 
            this.tbxAnyForeignLanguage.BackColor = System.Drawing.Color.Snow;
            this.tbxAnyForeignLanguage.Location = new System.Drawing.Point(371, 208);
            this.tbxAnyForeignLanguage.Name = "tbxAnyForeignLanguage";
            this.tbxAnyForeignLanguage.Size = new System.Drawing.Size(227, 20);
            this.tbxAnyForeignLanguage.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Wähle eine Fremdsprache aus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "oder eine beliebige verwenden";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fremdsprache:";
            // 
            // lCurrentForeignLanguage
            // 
            this.lCurrentForeignLanguage.AutoSize = true;
            this.lCurrentForeignLanguage.Location = new System.Drawing.Point(111, 84);
            this.lCurrentForeignLanguage.Name = "lCurrentForeignLanguage";
            this.lCurrentForeignLanguage.Size = new System.Drawing.Size(12, 16);
            this.lCurrentForeignLanguage.TabIndex = 19;
            this.lCurrentForeignLanguage.Text = "-";
            // 
            // UserModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxAnyForeignLanguage);
            this.Controls.Add(this.lbxSelectForeignLanguage);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnSaveUserData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxNickname);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNickname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lCurrentLanguage;
        private System.Windows.Forms.Label lCurrentNickname;
        private System.Windows.Forms.Button btnSaveUserData;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.ListBox lbxSelectForeignLanguage;
        private System.Windows.Forms.TextBox tbxAnyForeignLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lCurrentForeignLanguage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}