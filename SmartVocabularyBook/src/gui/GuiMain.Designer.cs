﻿namespace SmartVocabularyBook.vcbook.gui
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
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(53, 270);
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
            // GuiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
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
    }
}