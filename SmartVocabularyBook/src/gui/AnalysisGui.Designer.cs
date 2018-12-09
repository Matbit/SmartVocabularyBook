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
            this.btnOpenVocabularyView = new System.Windows.Forms.Button();
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
            // btnOpenVocabularyView
            // 
            this.btnOpenVocabularyView.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOpenVocabularyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenVocabularyView.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOpenVocabularyView.Location = new System.Drawing.Point(373, 390);
            this.btnOpenVocabularyView.Name = "btnOpenVocabularyView";
            this.btnOpenVocabularyView.Size = new System.Drawing.Size(227, 77);
            this.btnOpenVocabularyView.TabIndex = 1;
            this.btnOpenVocabularyView.Text = "zu meinen Vokabeln";
            this.btnOpenVocabularyView.UseVisualStyleBackColor = false;
            this.btnOpenVocabularyView.Click += new System.EventHandler(this.btnOpenVocabularyView_Click);
            // 
            // AnalysisGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnOpenVocabularyView);
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
        private System.Windows.Forms.Button btnOpenVocabularyView;
    }
}