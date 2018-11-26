using SmartVocabularyBook.src.gui;
using SmartVocabularyBook.src.model;
using SmartVocabularyBook.vcbook.controller;
using SmartVocabularyBook.vcbook.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartVocabularyBook
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            openPanelMain();
            
            DBController db = new DBController();
            db.initDB();            
        }

        //methods to open special forms in a panel
        public void openPanelMain()
        {
            this.panelMain.Controls.Clear();
            GuiMain main = new GuiMain(this);
            main.TopLevel = false;
            main.AutoScroll = true;
            this.panelMain.Controls.Add(main);
            main.Show();
            setMenuButton(false);

        }

        public void openPanelProgressManager()
        {
            this.panelMain.Controls.Clear();
            ProgressManager frm = new ProgressManager(this);
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.panelMain.Controls.Add(frm);
            frm.Show();
            setMenuButton(true);
        }

        public void openPanelTest()
        {
            this.panelMain.Controls.Clear();
            GuiTest test = new GuiTest(this);
            test.TopLevel = false;
            test.AutoScroll = true;
            this.panelMain.Controls.Add(test);
            test.Show();
            setMenuButton(false);
        }

        public void openPanelTestAnalysis(List<TestVocabularyModel> tvm)
        {
            this.panelMain.Controls.Clear();
            GuiTestAnalysis gta = new GuiTestAnalysis(this, tvm);
            gta.TopLevel = false;
            gta.AutoScroll = false;
            this.panelMain.Controls.Add(gta);
            gta.Show();
            setMenuButton(false);
        }

        public void openPanelAllTestsView()
        {
            this.panelMain.Controls.Clear();
            AnalysisGui gui = new AnalysisGui(this);
            gui.TopLevel = false;
            gui.AutoScroll = true;
            this.panelMain.Controls.Add(gui);
            gui.Show();
            setMenuButton(true);
        }

        public void openPanelOptions()
        {
            this.panelMain.Controls.Clear();
            Options gui = new Options(this);
            gui.TopLevel = false;
            gui.AutoScroll = true;
            this.panelMain.Controls.Add(gui);
            gui.Show();
            setMenuButton(true);
        }

        public void openPanelHelp()
        {
            this.panelMain.Controls.Clear();
            GuiHelp gui = new GuiHelp(this);
            gui.TopLevel = false;
            gui.AutoScroll = true;
            this.panelMain.Controls.Add(gui);
            gui.Show();
            setMenuButton(true);
        }

        //set menu button
        private void setMenuButton(bool isVisible)
        {
            btnOpenMain.Visible = isVisible;
        }


        public void setPanelMainVisible()
        {
            openPanelMain();
        }

        
        private void btnLearningProcess_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            
        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenMain_Click(object sender, EventArgs e)
        {
            openPanelMain();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            endApplication();
        }

        private void hauptmenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPanelMain();
        }

        private void endApplication()
        {
            Application.Exit();
        }

        private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPanelOptions();
        }

        private void hilfeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openPanelHelp();
        }
    }
}
