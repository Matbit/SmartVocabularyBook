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
            this.btnOpenPanelOptions = new System.Windows.Forms.Button();
            this.btnOpenHelp = new System.Windows.Forms.Button();
            this.btnOpenCreateUser = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(53, 388);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(138, 76);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "Beenden";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnLearningProgress
            // 
            this.btnLearningProgress.Location = new System.Drawing.Point(53, 60);
            this.btnLearningProgress.Name = "btnLearningProgress";
            this.btnLearningProgress.Size = new System.Drawing.Size(138, 76);
            this.btnLearningProgress.TabIndex = 1;
            this.btnLearningProgress.Text = "Lernprozess verwalten";
            this.btnLearningProgress.UseVisualStyleBackColor = true;
            this.btnLearningProgress.Click += new System.EventHandler(this.btnLearningProgress_Click);
            // 
            // btnOpenAllTestsView
            // 
            this.btnOpenAllTestsView.Location = new System.Drawing.Point(53, 142);
            this.btnOpenAllTestsView.Name = "btnOpenAllTestsView";
            this.btnOpenAllTestsView.Size = new System.Drawing.Size(138, 76);
            this.btnOpenAllTestsView.TabIndex = 2;
            this.btnOpenAllTestsView.Text = "Testanalyse";
            this.btnOpenAllTestsView.UseVisualStyleBackColor = true;
            this.btnOpenAllTestsView.Click += new System.EventHandler(this.btnOpenAllTestsView_Click);
            // 
            // btnOpenPanelOptions
            // 
            this.btnOpenPanelOptions.Location = new System.Drawing.Point(708, 60);
            this.btnOpenPanelOptions.Name = "btnOpenPanelOptions";
            this.btnOpenPanelOptions.Size = new System.Drawing.Size(138, 76);
            this.btnOpenPanelOptions.TabIndex = 3;
            this.btnOpenPanelOptions.Text = "Optionen";
            this.btnOpenPanelOptions.UseVisualStyleBackColor = true;
            this.btnOpenPanelOptions.Click += new System.EventHandler(this.btnOpenPanelOptions_Click);
            // 
            // btnOpenHelp
            // 
            this.btnOpenHelp.Location = new System.Drawing.Point(708, 142);
            this.btnOpenHelp.Name = "btnOpenHelp";
            this.btnOpenHelp.Size = new System.Drawing.Size(138, 76);
            this.btnOpenHelp.TabIndex = 4;
            this.btnOpenHelp.Text = "Hilfe";
            this.btnOpenHelp.UseVisualStyleBackColor = true;
            this.btnOpenHelp.Click += new System.EventHandler(this.btnOpenHelp_Click);
            // 
            // btnOpenCreateUser
            // 
            this.btnOpenCreateUser.Location = new System.Drawing.Point(53, 224);
            this.btnOpenCreateUser.Name = "btnOpenCreateUser";
            this.btnOpenCreateUser.Size = new System.Drawing.Size(138, 76);
            this.btnOpenCreateUser.TabIndex = 5;
            this.btnOpenCreateUser.Text = "Nutzer  bearbeiten";
            this.btnOpenCreateUser.UseVisualStyleBackColor = true;
            this.btnOpenCreateUser.Click += new System.EventHandler(this.btnOpenCreateUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(53, 306);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(138, 76);
            this.btnAddNewUser.TabIndex = 6;
            this.btnAddNewUser.Text = "Neuer Nutzer";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // GuiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnOpenCreateUser);
            this.Controls.Add(this.btnOpenHelp);
            this.Controls.Add(this.btnOpenPanelOptions);
            this.Controls.Add(this.btnOpenAllTestsView);
            this.Controls.Add(this.btnLearningProgress);
            this.Controls.Add(this.btnEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuiMain";
            this.Text = "#";
            this.Load += new System.EventHandler(this.GuiMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnLearningProgress;
        private System.Windows.Forms.Button btnOpenAllTestsView;
        private System.Windows.Forms.Button btnOpenPanelOptions;
        private System.Windows.Forms.Button btnOpenHelp;
        private System.Windows.Forms.Button btnOpenCreateUser;
        private System.Windows.Forms.Button btnAddNewUser;
    }
}