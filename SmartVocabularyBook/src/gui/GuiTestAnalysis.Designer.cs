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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTestAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartTestAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTestAnalysis
            // 
            this.chartTestAnalysis.BackColor = System.Drawing.Color.LightSkyBlue;
            chartArea1.Name = "ChartArea1";
            this.chartTestAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTestAnalysis.Legends.Add(legend1);
            this.chartTestAnalysis.Location = new System.Drawing.Point(572, 12);
            this.chartTestAnalysis.Name = "chartTestAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Lime;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Analysis";
            this.chartTestAnalysis.Series.Add(series1);
            this.chartTestAnalysis.Size = new System.Drawing.Size(316, 274);
            this.chartTestAnalysis.TabIndex = 1;
            this.chartTestAnalysis.Text = "chart1";
            // 
            // dataGridResult
            // 
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Location = new System.Drawing.Point(12, 12);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(554, 274);
            this.dataGridResult.TabIndex = 2;
            // 
            // GuiTestAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dataGridResult);
            this.Controls.Add(this.chartTestAnalysis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuiTestAnalysis";
            this.Text = "GuiTestAnalysis";
            this.Load += new System.EventHandler(this.GuiTestAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTestAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTestAnalysis;
        private System.Windows.Forms.DataGridView dataGridResult;
    }
}