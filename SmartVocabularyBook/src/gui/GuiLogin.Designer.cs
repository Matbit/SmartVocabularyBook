namespace SmartVocabularyBook.src.gui
{
    partial class GuiLogin
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
            this.lbxUser = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.gbxAddUser = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxLanguages = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddUserToDB = new System.Windows.Forms.Button();
            this.gbxAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anmeldung";
            // 
            // lbxUser
            // 
            this.lbxUser.FormattingEnabled = true;
            this.lbxUser.Location = new System.Drawing.Point(35, 134);
            this.lbxUser.Name = "lbxUser";
            this.lbxUser.Size = new System.Drawing.Size(186, 212);
            this.lbxUser.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(684, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 58);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Weiter";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wähle deinen Account aus und klicke auf Weiter";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(35, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(246, 134);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(58, 51);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "+";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // gbxAddUser
            // 
            this.gbxAddUser.Controls.Add(this.btnAddUserToDB);
            this.gbxAddUser.Controls.Add(this.label5);
            this.gbxAddUser.Controls.Add(this.lbxLanguages);
            this.gbxAddUser.Controls.Add(this.label4);
            this.gbxAddUser.Controls.Add(this.tbxNickname);
            this.gbxAddUser.Controls.Add(this.label3);
            this.gbxAddUser.Location = new System.Drawing.Point(386, 42);
            this.gbxAddUser.Name = "gbxAddUser";
            this.gbxAddUser.Size = new System.Drawing.Size(484, 304);
            this.gbxAddUser.TabIndex = 6;
            this.gbxAddUser.TabStop = false;
            this.gbxAddUser.Text = "Neuen Account anlegen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nickname*:";
            // 
            // tbxNickname
            // 
            this.tbxNickname.Location = new System.Drawing.Point(111, 31);
            this.tbxNickname.MaxLength = 50;
            this.tbxNickname.Name = "tbxNickname";
            this.tbxNickname.Size = new System.Drawing.Size(355, 20);
            this.tbxNickname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Muttersprache*:";
            // 
            // lbxLanguages
            // 
            this.lbxLanguages.FormattingEnabled = true;
            this.lbxLanguages.Location = new System.Drawing.Point(111, 62);
            this.lbxLanguages.Name = "lbxLanguages";
            this.lbxLanguages.Size = new System.Drawing.Size(355, 134);
            this.lbxLanguages.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Einstellungen können später noch geändert werden.";
            // 
            // btnAddUserToDB
            // 
            this.btnAddUserToDB.Location = new System.Drawing.Point(111, 235);
            this.btnAddUserToDB.Name = "btnAddUserToDB";
            this.btnAddUserToDB.Size = new System.Drawing.Size(355, 53);
            this.btnAddUserToDB.TabIndex = 8;
            this.btnAddUserToDB.Text = "Neuen Account erstellen!";
            this.btnAddUserToDB.UseVisualStyleBackColor = true;
            this.btnAddUserToDB.Click += new System.EventHandler(this.btnAddUserToDB_Click);
            // 
            // GuiLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.gbxAddUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbxUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuiLogin";
            this.Text = "GuiLogin";
            this.Load += new System.EventHandler(this.GuiLogin_Load);
            this.gbxAddUser.ResumeLayout(false);
            this.gbxAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxUser;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.GroupBox gbxAddUser;
        private System.Windows.Forms.ListBox lbxLanguages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNickname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddUserToDB;
    }
}