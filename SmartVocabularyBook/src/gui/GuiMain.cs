using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.service;
using SmartVocabularyBook.vcbook.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartVocabularyBook.vcbook.gui
{
    public partial class GuiMain : Form
    {
        private Main frmMain;

        //services
        private static InformationService serviceInformation = new InformationService();
        private static UserService serviceUser = new UserService();

        public GuiMain(Main main)
        {
            InitializeComponent();
            frmMain = main;
            setUserStats();
        }

        private void setUserStats()
        {
            try
            {
                User user = serviceUser.findUserById(getUserId());
                lNickname.Text = user.nickname;
                if(user.points < 2)
                {
                    lPoints.Text = user.points + " Punkt";
                }
                else
                {
                    lPoints.Text = user.points + " Punkte";
                }

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int getUserId()
        {
            List<Information> info = serviceInformation.getInformation();
            return info[0].userId;
        }

        private void GuiMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLearningProgress_Click(object sender, EventArgs e)
        {
            openGuiProgressManager();
        }

        private void openGuiProgressManager()
        {
            frmMain.openPanelProgressManager();
            
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {   
            
            Application.Exit();

        }

        private void btnOpenAllTestsView_Click(object sender, EventArgs e)
        {
            frmMain.openPanelAllTestsView();
        }

        private void btnOpenPanelOptions_Click(object sender, EventArgs e)
        {
            frmMain.openPanelOptions();
        }

        private void btnOpenHelp_Click(object sender, EventArgs e)
        {
            frmMain.openPanelHelp();
        }

        private void btnOpenCreateUser_Click(object sender, EventArgs e)
        {
            frmMain.openPanelUserModification();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain.openPanelLogin();
        }
    }
}
