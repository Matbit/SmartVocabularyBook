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
            this.btnGoOn = new System.Windows.Forms.Button();
            this.lTestResult = new System.Windows.Forms.Label();
            this.lGrade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResult
            // 
            this.dataGridResult.AllowUserToAddRows = false;
            this.dataGridResult.AllowUserToDeleteRows = false;
            this.dataGridResult.AllowUserToResizeColumns = false;
            this.dataGridResult.AllowUserToResizeRows = false;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Location = new System.Drawing.Point(2, 2);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(869, 282);
            this.dataGridResult.TabIndex = 2;
            // 
            // btnGoOn
            // 
            this.btnGoOn.Location = new System.Drawing.Point(777, 442);
            this.btnGoOn.Name = "btnGoOn";
            this.btnGoOn.Size = new System.Drawing.Size(111, 46);
            this.btnGoOn.TabIndex = 3;
            this.btnGoOn.Text = "Weiter";
            this.btnGoOn.UseVisualStyleBackColor = true;
            this.btnGoOn.Click += new System.EventHandler(this.btnGoOn_Click);
            // 
            // lTestResult
            // 
            this.lTestResult.AutoSize = true;
            this.lTestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTestResult.Location = new System.Drawing.Point(89, 313);
            this.lTestResult.Name = "lTestResult";
            this.lTestResult.Size = new System.Drawing.Size(60, 24);
            this.lTestResult.TabIndex = 4;
            this.lTestResult.Text = "label1";
            // 
            // lGrade
            // 
            this.lGrade.AutoSize = true;
            this.lGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGrade.Location = new System.Drawing.Point(441, 366);
            this.lGrade.Name = "lGrade";
            this.lGrade.Size = new System.Drawing.Size(85, 29);
            this.lGrade.TabIndex = 5;
            this.lGrade.Text = "label1";
            // 
            // GuiTestAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lGrade);
            this.Controls.Add(this.lTestResult);
            this.Controls.Add(this.btnGoOn);
            this.Controls.Add(this.dataGridResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuiTestAnalysis";
            this.Text = "GuiTestAnalysis";
            this.Load += new System.EventHandler(this.GuiTestAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.Button btnGoOn;
        private System.Windows.Forms.Label lTestResult;
        private System.Windows.Forms.Label lGrade;
    }
}