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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiHelp));
            this.label1 = new System.Windows.Forms.Label();
            this.rtbxHelpText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearchWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // rtbxHelpText
            // 
            this.rtbxHelpText.BackColor = System.Drawing.Color.LightGreen;
            this.rtbxHelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxHelpText.Location = new System.Drawing.Point(17, 86);
            this.rtbxHelpText.Name = "rtbxHelpText";
            this.rtbxHelpText.ReadOnly = true;
            this.rtbxHelpText.Size = new System.Drawing.Size(858, 386);
            this.rtbxHelpText.TabIndex = 3;
            this.rtbxHelpText.Text = resources.GetString("rtbxHelpText.Text");
            this.rtbxHelpText.TextChanged += new System.EventHandler(this.rtbxHelpText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suche nach Wort:";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(402, 49);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(140, 20);
            this.tbxSearch.TabIndex = 5;
            // 
            // btnSearchWord
            // 
            this.btnSearchWord.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnSearchWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchWord.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSearchWord.Location = new System.Drawing.Point(563, 46);
            this.btnSearchWord.Name = "btnSearchWord";
            this.btnSearchWord.Size = new System.Drawing.Size(75, 23);
            this.btnSearchWord.TabIndex = 6;
            this.btnSearchWord.Text = "Suche!";
            this.btnSearchWord.UseVisualStyleBackColor = false;
            this.btnSearchWord.Click += new System.EventHandler(this.btnSearchWord_Click);
            // 
            // GuiHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnSearchWord);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbxHelpText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuiHelp";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbxHelpText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearchWord;
    }
}