namespace SmartVocabularyBook.src.gui
{
    partial class Options
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
            this.chbxDefaultTestSettings = new System.Windows.Forms.CheckBox();
            this.grbxSetTest = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorBackground = new System.Windows.Forms.Button();
            this.grbxSetTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbxDefaultTestSettings
            // 
            this.chbxDefaultTestSettings.AutoSize = true;
            this.chbxDefaultTestSettings.Location = new System.Drawing.Point(15, 32);
            this.chbxDefaultTestSettings.Name = "chbxDefaultTestSettings";
            this.chbxDefaultTestSettings.Size = new System.Drawing.Size(214, 17);
            this.chbxDefaultTestSettings.TabIndex = 0;
            this.chbxDefaultTestSettings.Text = "Diese Werte bei jedem Start verwenden";
            this.chbxDefaultTestSettings.UseVisualStyleBackColor = true;
            // 
            // grbxSetTest
            // 
            this.grbxSetTest.Controls.Add(this.label3);
            this.grbxSetTest.Controls.Add(this.label2);
            this.grbxSetTest.Controls.Add(this.label1);
            this.grbxSetTest.Controls.Add(this.chbxDefaultTestSettings);
            this.grbxSetTest.Location = new System.Drawing.Point(12, 27);
            this.grbxSetTest.Name = "grbxSetTest";
            this.grbxSetTest.Size = new System.Drawing.Size(279, 439);
            this.grbxSetTest.TabIndex = 1;
            this.grbxSetTest.TabStop = false;
            this.grbxSetTest.Text = "Test Einstellungen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vokabel: Neueste Vokabeln";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl: 10 Vokabeln";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vorgebenes Wort in: Hauptsprache";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnColorBackground);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(297, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 439);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Layout";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(156, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Standart Layout verwenden";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnColorBackground
            // 
            this.btnColorBackground.Location = new System.Drawing.Point(16, 118);
            this.btnColorBackground.Name = "btnColorBackground";
            this.btnColorBackground.Size = new System.Drawing.Size(133, 32);
            this.btnColorBackground.TabIndex = 2;
            this.btnColorBackground.Text = "Hintergrundfarbe";
            this.btnColorBackground.UseVisualStyleBackColor = true;
            this.btnColorBackground.Click += new System.EventHandler(this.btnColorBackground_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbxSetTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.grbxSetTest.ResumeLayout(false);
            this.grbxSetTest.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbxDefaultTestSettings;
        private System.Windows.Forms.GroupBox grbxSetTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnColorBackground;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}