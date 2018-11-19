namespace SmartVocabularyBook.src.gui
{
    partial class GuiTestAnalysis
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
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.panelDataView = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.panelDataView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridResult
            // 
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Location = new System.Drawing.Point(3, 3);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(852, 323);
            this.dataGridResult.TabIndex = 2;
            // 
            // panelDataView
            // 
            this.panelDataView.Controls.Add(this.dataGridResult);
            this.panelDataView.Location = new System.Drawing.Point(2, 1);
            this.panelDataView.Name = "panelDataView";
            this.panelDataView.Size = new System.Drawing.Size(897, 347);
            this.panelDataView.TabIndex = 5;
            // 
            // GuiTestAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panelDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuiTestAnalysis";
            this.Text = "GuiTestAnalysis";
            this.Load += new System.EventHandler(this.GuiTestAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.panelDataView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.Panel panelDataView;
    }
}