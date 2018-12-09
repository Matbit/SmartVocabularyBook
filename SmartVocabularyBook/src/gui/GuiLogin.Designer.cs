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
            this.btnAddUserToDB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxLanguages = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anmeldung";
            // 
            // lbxUser
            // 
            this.lbxUser.BackColor = System.Drawing.Color.Snow;
            this.lbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUser.FormattingEnabled = true;
            this.lbxUser.ItemHeight = 16;
            this.lbxUser.Location = new System.Drawing.Point(35, 134);
            this.lbxUser.Name = "lbxUser";
            this.lbxUser.Size = new System.Drawing.Size(186, 212);
            this.lbxUser.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Location = new System.Drawing.Point(684, 380);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 58);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Weiter";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wähle deinen Account aus und klicke auf Weiter";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnExit.Location = new System.Drawing.Point(35, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 58);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddUser.Location = new System.Drawing.Point(246, 134);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(58, 51);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "+";
            this.btnAddUser.UseVisualStyleBackColor = false;
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
            // btnAddUserToDB
            // 
            this.btnAddUserToDB.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAddUserToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserToDB.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddUserToDB.Location = new System.Drawing.Point(111, 235);
            this.btnAddUserToDB.Name = "btnAddUserToDB";
            this.btnAddUserToDB.Size = new System.Drawing.Size(355, 53);
            this.btnAddUserToDB.TabIndex = 8;
            this.btnAddUserToDB.Text = "Neuen Account erstellen!";
            this.btnAddUserToDB.UseVisualStyleBackColor = false;
            this.btnAddUserToDB.Click += new System.EventHandler(this.btnAddUserToDB_Click);
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
            // lbxLanguages
            // 
            this.lbxLanguages.BackColor = System.Drawing.Color.Snow;
            this.lbxLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxLanguages.FormattingEnabled = true;
            this.lbxLanguages.ItemHeight = 16;
            this.lbxLanguages.Location = new System.Drawing.Point(111, 62);
            this.lbxLanguages.Name = "lbxLanguages";
            this.lbxLanguages.Size = new System.Drawing.Size(355, 132);
            this.lbxLanguages.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Muttersprache*:";
            // 
            // tbxNickname
            // 
            this.tbxNickname.BackColor = System.Drawing.Color.Snow;
            this.tbxNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNickname.Location = new System.Drawing.Point(111, 31);
            this.tbxNickname.MaxLength = 50;
            this.tbxNickname.Name = "tbxNickname";
            this.tbxNickname.Size = new System.Drawing.Size(355, 22);
            this.tbxNickname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nickname*:";
            // 
            // GuiLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
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