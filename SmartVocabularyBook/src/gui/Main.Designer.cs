namespace SmartVocabularyBook
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptmenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnOpenMain = new System.Windows.Forms.Button();
            this.btnOpenTestAnalysis = new System.Windows.Forms.Button();
            this.geheZuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neueVokabelnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übungTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutzerBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptmenüToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtVokabelnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.geheZuToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hauptmenüToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // hauptmenüToolStripMenuItem
            // 
            this.hauptmenüToolStripMenuItem.Name = "hauptmenüToolStripMenuItem";
            this.hauptmenüToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.hauptmenüToolStripMenuItem.Text = "Abmelden";
            this.hauptmenüToolStripMenuItem.Click += new System.EventHandler(this.hauptmenüToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hilfeToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // hilfeToolStripMenuItem1
            // 
            this.hilfeToolStripMenuItem1.Name = "hilfeToolStripMenuItem1";
            this.hilfeToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.hilfeToolStripMenuItem1.Text = "Hilfe";
            this.hilfeToolStripMenuItem1.Click += new System.EventHandler(this.hilfeToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(0, 37);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 500);
            this.panelMain.TabIndex = 5;
            // 
            // btnOpenMain
            // 
            this.btnOpenMain.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOpenMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMain.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOpenMain.Location = new System.Drawing.Point(779, 555);
            this.btnOpenMain.Name = "btnOpenMain";
            this.btnOpenMain.Size = new System.Drawing.Size(103, 46);
            this.btnOpenMain.TabIndex = 6;
            this.btnOpenMain.Text = "Hauptmenü";
            this.btnOpenMain.UseVisualStyleBackColor = false;
            this.btnOpenMain.Click += new System.EventHandler(this.btnOpenMain_Click);
            // 
            // btnOpenTestAnalysis
            // 
            this.btnOpenTestAnalysis.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOpenTestAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTestAnalysis.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOpenTestAnalysis.Location = new System.Drawing.Point(421, 555);
            this.btnOpenTestAnalysis.Name = "btnOpenTestAnalysis";
            this.btnOpenTestAnalysis.Size = new System.Drawing.Size(103, 46);
            this.btnOpenTestAnalysis.TabIndex = 7;
            this.btnOpenTestAnalysis.Text = "Testanalyse";
            this.btnOpenTestAnalysis.UseVisualStyleBackColor = false;
            this.btnOpenTestAnalysis.Click += new System.EventHandler(this.btnOpenTestAnalysis_Click);
            // 
            // geheZuToolStripMenuItem
            // 
            this.geheZuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neueVokabelnToolStripMenuItem,
            this.übungTestToolStripMenuItem,
            this.analyseToolStripMenuItem,
            this.hauptmenüToolStripMenuItem1,
            this.übersichtVokabelnToolStripMenuItem,
            this.nutzerBearbeitenToolStripMenuItem});
            this.geheZuToolStripMenuItem.Name = "geheZuToolStripMenuItem";
            this.geheZuToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.geheZuToolStripMenuItem.Text = "Gehe Zu";
            // 
            // neueVokabelnToolStripMenuItem
            // 
            this.neueVokabelnToolStripMenuItem.Name = "neueVokabelnToolStripMenuItem";
            this.neueVokabelnToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.neueVokabelnToolStripMenuItem.Text = "Neue Vokabeln";
            this.neueVokabelnToolStripMenuItem.Click += new System.EventHandler(this.neueVokabelnToolStripMenuItem_Click);
            // 
            // übungTestToolStripMenuItem
            // 
            this.übungTestToolStripMenuItem.Name = "übungTestToolStripMenuItem";
            this.übungTestToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.übungTestToolStripMenuItem.Text = "Übung/ Test";
            this.übungTestToolStripMenuItem.Click += new System.EventHandler(this.übungTestToolStripMenuItem_Click);
            // 
            // analyseToolStripMenuItem
            // 
            this.analyseToolStripMenuItem.Name = "analyseToolStripMenuItem";
            this.analyseToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.analyseToolStripMenuItem.Text = "Testanalyse";
            this.analyseToolStripMenuItem.Click += new System.EventHandler(this.analyseToolStripMenuItem_Click);
            // 
            // nutzerBearbeitenToolStripMenuItem
            // 
            this.nutzerBearbeitenToolStripMenuItem.Name = "nutzerBearbeitenToolStripMenuItem";
            this.nutzerBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nutzerBearbeitenToolStripMenuItem.Text = "Nutzer bearbeiten";
            this.nutzerBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.nutzerBearbeitenToolStripMenuItem_Click);
            // 
            // hauptmenüToolStripMenuItem1
            // 
            this.hauptmenüToolStripMenuItem1.Name = "hauptmenüToolStripMenuItem1";
            this.hauptmenüToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.hauptmenüToolStripMenuItem1.Text = "Hauptmenü";
            this.hauptmenüToolStripMenuItem1.Click += new System.EventHandler(this.hauptmenüToolStripMenuItem1_Click);
            // 
            // übersichtVokabelnToolStripMenuItem
            // 
            this.übersichtVokabelnToolStripMenuItem.Name = "übersichtVokabelnToolStripMenuItem";
            this.übersichtVokabelnToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.übersichtVokabelnToolStripMenuItem.Text = "Übersicht Vokabeln";
            this.übersichtVokabelnToolStripMenuItem.Click += new System.EventHandler(this.übersichtVokabelnToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(908, 625);
            this.Controls.Add(this.btnOpenTestAnalysis);
            this.Controls.Add(this.btnOpenMain);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vokabeltrainer - Dein smartes Vokabelheft";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnOpenMain;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptmenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnOpenTestAnalysis;
        private System.Windows.Forms.ToolStripMenuItem geheZuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neueVokabelnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übungTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nutzerBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptmenüToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem übersichtVokabelnToolStripMenuItem;
    }
}

