namespace SmartVocabularyBook.vcbook.gui
{
    partial class GuiMain
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
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnLearningProgress = new System.Windows.Forms.Button();
            this.btnOpenAllTestsView = new System.Windows.Forms.Button();
            this.btnOpenHelp = new System.Windows.Forms.Button();
            this.btnOpenCreateUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.lNickname = new System.Windows.Forms.Label();
            this.lPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lPlayersStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.Tomato;
            this.btnEnd.Location = new System.Drawing.Point(708, 371);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(138, 76);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "Beenden";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnLearningProgress
            // 
            this.btnLearningProgress.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLearningProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearningProgress.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLearningProgress.Location = new System.Drawing.Point(53, 44);
            this.btnLearningProgress.Name = "btnLearningProgress";
            this.btnLearningProgress.Size = new System.Drawing.Size(138, 76);
            this.btnLearningProgress.TabIndex = 1;
            this.btnLearningProgress.Text = "Lernprozess verwalten";
            this.btnLearningProgress.UseVisualStyleBackColor = false;
            this.btnLearningProgress.Click += new System.EventHandler(this.btnLearningProgress_Click);
            // 
            // btnOpenAllTestsView
            // 
            this.btnOpenAllTestsView.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOpenAllTestsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAllTestsView.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOpenAllTestsView.Location = new System.Drawing.Point(53, 126);
            this.btnOpenAllTestsView.Name = "btnOpenAllTestsView";
            this.btnOpenAllTestsView.Size = new System.Drawing.Size(138, 76);
            this.btnOpenAllTestsView.TabIndex = 2;
            this.btnOpenAllTestsView.Text = "Testanalyse";
            this.btnOpenAllTestsView.UseVisualStyleBackColor = false;
            this.btnOpenAllTestsView.Click += new System.EventHandler(this.btnOpenAllTestsView_Click);
            // 
            // btnOpenHelp
            // 
            this.btnOpenHelp.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOpenHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenHelp.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOpenHelp.Location = new System.Drawing.Point(708, 44);
            this.btnOpenHelp.Name = "btnOpenHelp";
            this.btnOpenHelp.Size = new System.Drawing.Size(138, 76);
            this.btnOpenHelp.TabIndex = 4;
            this.btnOpenHelp.Text = "Hilfe";
            this.btnOpenHelp.UseVisualStyleBackColor = false;
            this.btnOpenHelp.Click += new System.EventHandler(this.btnOpenHelp_Click);
            // 
            // btnOpenCreateUser
            // 
            this.btnOpenCreateUser.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOpenCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCreateUser.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOpenCreateUser.Location = new System.Drawing.Point(53, 208);
            this.btnOpenCreateUser.Name = "btnOpenCreateUser";
            this.btnOpenCreateUser.Size = new System.Drawing.Size(138, 76);
            this.btnOpenCreateUser.TabIndex = 5;
            this.btnOpenCreateUser.Text = "Nutzer  bearbeiten";
            this.btnOpenCreateUser.UseVisualStyleBackColor = false;
            this.btnOpenCreateUser.Click += new System.EventHandler(this.btnOpenCreateUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLogout.Location = new System.Drawing.Point(53, 290);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(138, 75);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Abmelden";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(257, 44);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(389, 240);
            this.picbox.TabIndex = 7;
            this.picbox.TabStop = false;
            // 
            // lNickname
            // 
            this.lNickname.AutoSize = true;
            this.lNickname.Location = new System.Drawing.Point(254, 290);
            this.lNickname.Name = "lNickname";
            this.lNickname.Size = new System.Drawing.Size(58, 13);
            this.lNickname.TabIndex = 8;
            this.lNickname.Text = "Nickname:";
            // 
            // lPoints
            // 
            this.lPoints.AutoSize = true;
            this.lPoints.Location = new System.Drawing.Point(318, 290);
            this.lPoints.Name = "lPoints";
            this.lPoints.Size = new System.Drawing.Size(50, 13);
            this.lPoints.TabIndex = 9;
            this.lPoints.Text = "5 Punkte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rank:";
            // 
            // lPlayersStatus
            // 
            this.lPlayersStatus.AutoSize = true;
            this.lPlayersStatus.Location = new System.Drawing.Point(318, 312);
            this.lPlayersStatus.Name = "lPlayersStatus";
            this.lPlayersStatus.Size = new System.Drawing.Size(99, 13);
            this.lPlayersStatus.TabIndex = 11;
            this.lPlayersStatus.Text = "\"Brutaler Anfänger\"";
            // 
            // GuiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lPlayersStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lPoints);
            this.Controls.Add(this.lNickname);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOpenCreateUser);
            this.Controls.Add(this.btnOpenHelp);
            this.Controls.Add(this.btnOpenAllTestsView);
            this.Controls.Add(this.btnLearningProgress);
            this.Controls.Add(this.btnEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuiMain";
            this.Text = "#";
            this.Load += new System.EventHandler(this.GuiMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnLearningProgress;
        private System.Windows.Forms.Button btnOpenAllTestsView;
        private System.Windows.Forms.Button btnOpenHelp;
        private System.Windows.Forms.Button btnOpenCreateUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label lNickname;
        private System.Windows.Forms.Label lPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lPlayersStatus;
    }
}