namespace SmartVocabularyBook.src.gui
{
    partial class AnalysisGui
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
            this.dataGridAllTests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllTests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAllTests
            // 
            this.dataGridAllTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllTests.Location = new System.Drawing.Point(0, 0);
            this.dataGridAllTests.Name = "dataGridAllTests";
            this.dataGridAllTests.Size = new System.Drawing.Size(900, 294);
            this.dataGridAllTests.TabIndex = 0;
            // 
            // AnalysisGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dataGridAllTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalysisGui";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.AnalysisGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllTests;
    }
}