using SmartVocabularyBook.src.gui;
using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.service;
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
        static UserService serviceUser = new UserService();
        static InformationService serviceInformation = new InformationService();
        static List<Information> information; 
        
        public Main()
        {
            DBController db = new DBController();
            db.initDB();
            InitializeComponent();
            information = serviceInformation.getInformation();
            setMenuStrip(false);
            //openPanelMain();
            openPanelLogin();
            setColor();  
           

            setWelcomeText(information[0].userId);            
        }

        //welcome user
        public void setWelcomeText(int id)
        {

            User user = new User();
            user.id = id;
            user = serviceUser.findUserById(getUserId());
            this.Text = "Vokabeltrainer  für " + user.nickname +" - Dein smartes Vokabelheft";
        }

        private int getUserId()
        {
            List<Information> info = serviceInformation.getInformation();
            return info[0].userId;
        }

        //set colour
        private void setColor()
        {
            menuStrip1.BackColor = Color.Navy;
            menuStrip1.ForeColor = Color.WhiteSmoke;
        }

        public void setMenuStrip(bool isVisible)
        {
            menuStrip1.Visible = isVisible;
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
            setTestAnalysisButton(false);
            

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
            setTestAnalysisButton(true);
        }

        public void openPanelTest(bool save)
        {
            this.panelMain.Controls.Clear();
            GuiTest test = new GuiTest(this, save);
            test.TopLevel = false;
            test.AutoScroll = true;
            this.panelMain.Controls.Add(test);
            test.Show();
            setMenuButton(false);
            setTestAnalysisButton(false);
        }

        public void openPanelTestAnalysis(List<TestVocabularyModel> tvm, bool save)
        {
            this.panelMain.Controls.Clear();
            GuiTestAnalysis gta = new GuiTestAnalysis(this, tvm, save);
            gta.TopLevel = false;
            gta.AutoScroll = false;
            this.panelMain.Controls.Add(gta);
            gta.Show();
            setMenuButton(true);
            setTestAnalysisButton(true);
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
            setTestAnalysisButton(false);
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
            setTestAnalysisButton(false);
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
            setTestAnalysisButton(false);
        }

        public void openPanelUserModification()
        {
            this.panelMain.Controls.Clear();
            UserModification gui = new UserModification(this);
            gui.TopLevel = false;
            gui.AutoScroll = true;
            this.panelMain.Controls.Add(gui);
            gui.Show();
            setMenuButton(false);
            setTestAnalysisButton(false);
        }

        public void openPanelLogin()
        {
            this.panelMain.Controls.Clear();
            GuiLogin gui = new GuiLogin(this);
            gui.TopLevel = false;
            gui.AutoScroll = true;
            this.panelMain.Controls.Add(gui);
            gui.Show();
            setMenuButton(false);
            setTestAnalysisButton(false);
            setMenuStrip(false);
        }


        //set menu button
        private void setMenuButton(bool isVisible)
        {
            btnOpenMain.Visible = isVisible;
        }

        //set test button
        private void setTestAnalysisButton(bool isVisible)
        {
            btnOpenTestAnalysis.Visible = isVisible;
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
            openPanelLogin();
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

        private void btnOpenTestAnalysis_Click(object sender, EventArgs e)
        {
            openPanelAllTestsView();
        }
    }
}
