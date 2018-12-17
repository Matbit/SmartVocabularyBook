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
        private static RankService serviceRank = new RankService();

        public GuiMain(Main main)
        {
            InitializeComponent();
            frmMain = main;
            setUserStats();
            setPicBox();
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

                Rank rank = serviceRank.getRank(user.points);
                lUserStatus.Text = "\""+rank.rankTitle+"\"";
                lLevel.Text = "Level " + rank.id;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setPicBox()
        {
            try
            {
                User user = serviceUser.findUserById(getUserId());
                Rank rank = serviceRank.getRank(user.points);
                int level = rank.id;


                if(level == 1)
                {
                    picbox.Image = Properties.Resources.pic1;
                }
                else if(level == 2)
                {
                    picbox.Image = Properties.Resources.pic2;
                }
                else if(level == 3)
                {
                    picbox.Image = Properties.Resources.pic3;
                }
                else if(level == 4)
                {
                    picbox.Image = Properties.Resources.pic4;
                }
                else if(level == 5)
                {
                    picbox.Image = Properties.Resources.pic5;
                }
                else if(level == 6)
                {
                    picbox.Image = Properties.Resources.pic6;
                }
                else if(level == 7)
                {
                    picbox.Image = Properties.Resources.pic7;
                }
                else if(level == 8)
                {
                    picbox.Image = Properties.Resources.pic8;
                }
                else if(level == 9)
                {
                    picbox.Image = Properties.Resources.pic9;
                }
                else if(level == 10)
                {
                    picbox.Image = Properties.Resources.pic10;
                }
                else if(level == 11)
                {
                    picbox.Image = Properties.Resources.pic11;
                }
                else if(level == 12)
                {
                    picbox.Image = Properties.Resources.pic12;
                }
                else if(level == 13)
                {
                    picbox.Image = Properties.Resources.pic13;
                }
                else if(level == 14)
                {
                    picbox.Image = Properties.Resources.pic14;
                }
                else if(level == 15)
                {
                    picbox.Image = Properties.Resources.pic15;
                }
                else if(level == 16)
                {
                    picbox.Image = Properties.Resources.pic16;
                }
                else if(level == 17)
                {
                    picbox.Image = Properties.Resources.pic17;
                }
                else if(level == 18)
                {
                    picbox.Image = Properties.Resources.pic18;
                }
                else if(level == 19)
                {
                    picbox.Image = Properties.Resources.pic19;
                }
                else if(level == 20)
                {
                    picbox.Image = Properties.Resources.pic20;
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

        private void btnCheetPoints_Click(object sender, EventArgs e)
        {

            cheetPointsMethod();
        }

        private void cheetPointsMethod()
        {
            User user = serviceUser.findUserById(getUserId());
            user.id = getUserId();

            int points = user.points + 1;
            serviceUser.updateUserPointsById(user.id, points);

            setUserStats();
            setPicBox();
        }

        private void picbox_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenHelp_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnOpenHelp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
