namespace SmartVocabularyBook.src.gui
{
    partial class GuiHelp
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
            this.tbxShowHelp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxShowHelp
            // 
            this.tbxShowHelp.BackColor = System.Drawing.SystemColors.Info;
            this.tbxShowHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxShowHelp.Location = new System.Drawing.Point(108, 63);
            this.tbxShowHelp.Multiline = true;
            this.tbxShowHelp.Name = "tbxShowHelp";
            this.tbxShowHelp.ReadOnly = true;
            this.tbxShowHelp.Size = new System.Drawing.Size(690, 370);
            this.tbxShowHelp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hilfe und Erläuterungen";
            // 
            // GuiHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxShowHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuiHelp";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxShowHelp;
        private System.Windows.Forms.Label label1;
    }
}