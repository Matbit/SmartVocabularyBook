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
            this.btnLast10Entries = new System.Windows.Forms.Button();
            this.btnShowAllTests = new System.Windows.Forms.Button();
            this.btnLast20Tests = new System.Windows.Forms.Button();
            this.btnLast30Tests = new System.Windows.Forms.Button();
            this.lResultPoints = new System.Windows.Forms.Label();
            this.btnMaxPoints = new System.Windows.Forms.Button();
            this.btnMinimumPoints = new System.Windows.Forms.Button();
            this.btnAvgPoints = new System.Windows.Forms.Button();
            this.lResultCountMistakes = new System.Windows.Forms.Label();
            this.lResultGrade = new System.Windows.Forms.Label();
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
            this.btnOpenVocabularyView.Location = new System.Drawing.Point(718, 445);
            this.btnOpenVocabularyView.Name = "btnOpenVocabularyView";
            this.btnOpenVocabularyView.Size = new System.Drawing.Size(170, 43);
            this.btnOpenVocabularyView.TabIndex = 1;
            this.btnOpenVocabularyView.Text = "zu meinen Vokabeln";
            this.btnOpenVocabularyView.UseVisualStyleBackColor = false;
            this.btnOpenVocabularyView.Click += new System.EventHandler(this.btnOpenVocabularyView_Click);
            // 
            // btnLast10Entries
            // 
            this.btnLast10Entries.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLast10Entries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast10Entries.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLast10Entries.Location = new System.Drawing.Point(0, 300);
            this.btnLast10Entries.Name = "btnLast10Entries";
            this.btnLast10Entries.Size = new System.Drawing.Size(178, 38);
            this.btnLast10Entries.TabIndex = 2;
            this.btnLast10Entries.Text = "Letzten 10 Ergebnisse";
            this.btnLast10Entries.UseVisualStyleBackColor = false;
            this.btnLast10Entries.Click += new System.EventHandler(this.btnLast10Entries_Click);
            // 
            // btnShowAllTests
            // 
            this.btnShowAllTests.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnShowAllTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllTests.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnShowAllTests.Location = new System.Drawing.Point(0, 420);
            this.btnShowAllTests.Name = "btnShowAllTests";
            this.btnShowAllTests.Size = new System.Drawing.Size(178, 38);
            this.btnShowAllTests.TabIndex = 3;
            this.btnShowAllTests.Text = "Alle Ergebnisse";
            this.btnShowAllTests.UseVisualStyleBackColor = false;
            this.btnShowAllTests.Click += new System.EventHandler(this.btnShowAllTests_Click);
            // 
            // btnLast20Tests
            // 
            this.btnLast20Tests.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLast20Tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast20Tests.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLast20Tests.Location = new System.Drawing.Point(0, 338);
            this.btnLast20Tests.Name = "btnLast20Tests";
            this.btnLast20Tests.Size = new System.Drawing.Size(178, 38);
            this.btnLast20Tests.TabIndex = 4;
            this.btnLast20Tests.Text = "Letzten 20 Ergebnisse";
            this.btnLast20Tests.UseVisualStyleBackColor = false;
            this.btnLast20Tests.Click += new System.EventHandler(this.btnLast25Tests_Click);
            // 
            // btnLast30Tests
            // 
            this.btnLast30Tests.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLast30Tests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Tests.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnLast30Tests.Location = new System.Drawing.Point(0, 376);
            this.btnLast30Tests.Name = "btnLast30Tests";
            this.btnLast30Tests.Size = new System.Drawing.Size(178, 38);
            this.btnLast30Tests.TabIndex = 5;
            this.btnLast30Tests.Text = "Letzten 30 Ergebnisse";
            this.btnLast30Tests.UseVisualStyleBackColor = false;
            this.btnLast30Tests.Click += new System.EventHandler(this.btnLast30Tests_Click);
            // 
            // lResultPoints
            // 
            this.lResultPoints.AutoSize = true;
            this.lResultPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResultPoints.ForeColor = System.Drawing.Color.Blue;
            this.lResultPoints.Location = new System.Drawing.Point(236, 306);
            this.lResultPoints.Name = "lResultPoints";
            this.lResultPoints.Size = new System.Drawing.Size(30, 24);
            this.lResultPoints.TabIndex = 6;
            this.lResultPoints.Text = "10";
            this.lResultPoints.Visible = false;
            // 
            // btnMaxPoints
            // 
            this.btnMaxPoints.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMaxPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxPoints.ForeColor = System.Drawing.Color.Tomato;
            this.btnMaxPoints.Location = new System.Drawing.Point(342, 357);
            this.btnMaxPoints.Name = "btnMaxPoints";
            this.btnMaxPoints.Size = new System.Drawing.Size(178, 38);
            this.btnMaxPoints.TabIndex = 7;
            this.btnMaxPoints.Text = "Bester Wert";
            this.btnMaxPoints.UseVisualStyleBackColor = false;
            this.btnMaxPoints.Click += new System.EventHandler(this.btnMaxPoints_Click);
            // 
            // btnMinimumPoints
            // 
            this.btnMinimumPoints.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMinimumPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimumPoints.ForeColor = System.Drawing.Color.Tomato;
            this.btnMinimumPoints.Location = new System.Drawing.Point(342, 444);
            this.btnMinimumPoints.Name = "btnMinimumPoints";
            this.btnMinimumPoints.Size = new System.Drawing.Size(178, 38);
            this.btnMinimumPoints.TabIndex = 8;
            this.btnMinimumPoints.Text = "Schlechtester Wert";
            this.btnMinimumPoints.UseVisualStyleBackColor = false;
            this.btnMinimumPoints.Click += new System.EventHandler(this.btnMinimumPoints_Click);
            // 
            // btnAvgPoints
            // 
            this.btnAvgPoints.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAvgPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvgPoints.ForeColor = System.Drawing.Color.Tomato;
            this.btnAvgPoints.Location = new System.Drawing.Point(342, 401);
            this.btnAvgPoints.Name = "btnAvgPoints";
            this.btnAvgPoints.Size = new System.Drawing.Size(178, 37);
            this.btnAvgPoints.TabIndex = 9;
            this.btnAvgPoints.Text = "Durchschnittswert";
            this.btnAvgPoints.UseVisualStyleBackColor = false;
            this.btnAvgPoints.Click += new System.EventHandler(this.btnAvgPoints_Click);
            // 
            // lResultCountMistakes
            // 
            this.lResultCountMistakes.AutoSize = true;
            this.lResultCountMistakes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResultCountMistakes.ForeColor = System.Drawing.Color.Blue;
            this.lResultCountMistakes.Location = new System.Drawing.Point(463, 306);
            this.lResultCountMistakes.Name = "lResultCountMistakes";
            this.lResultCountMistakes.Size = new System.Drawing.Size(20, 24);
            this.lResultCountMistakes.TabIndex = 10;
            this.lResultCountMistakes.Text = "1";
            this.lResultCountMistakes.Visible = false;
            // 
            // lResultGrade
            // 
            this.lResultGrade.AutoSize = true;
            this.lResultGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResultGrade.ForeColor = System.Drawing.Color.Blue;
            this.lResultGrade.Location = new System.Drawing.Point(682, 306);
            this.lResultGrade.Name = "lResultGrade";
            this.lResultGrade.Size = new System.Drawing.Size(20, 24);
            this.lResultGrade.TabIndex = 11;
            this.lResultGrade.Text = "2";
            this.lResultGrade.Visible = false;
            // 
            // AnalysisGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lResultGrade);
            this.Controls.Add(this.lResultCountMistakes);
            this.Controls.Add(this.btnAvgPoints);
            this.Controls.Add(this.btnMinimumPoints);
            this.Controls.Add(this.btnMaxPoints);
            this.Controls.Add(this.lResultPoints);
            this.Controls.Add(this.btnLast30Tests);
            this.Controls.Add(this.btnLast20Tests);
            this.Controls.Add(this.btnShowAllTests);
            this.Controls.Add(this.btnLast10Entries);
            this.Controls.Add(this.btnOpenVocabularyView);
            this.Controls.Add(this.dataGridAllTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalysisGui";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.AnalysisGui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllTests;
        private System.Windows.Forms.Button btnOpenVocabularyView;
        private System.Windows.Forms.Button btnLast10Entries;
        private System.Windows.Forms.Button btnShowAllTests;
        private System.Windows.Forms.Button btnLast20Tests;
        private System.Windows.Forms.Button btnLast30Tests;
        private System.Windows.Forms.Label lResultPoints;
        private System.Windows.Forms.Button btnMaxPoints;
        private System.Windows.Forms.Button btnMinimumPoints;
        private System.Windows.Forms.Button btnAvgPoints;
        private System.Windows.Forms.Label lResultCountMistakes;
        private System.Windows.Forms.Label lResultGrade;
    }
}