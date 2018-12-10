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
                    picbox.Image = Image.FromFile("pic1.gif");
                }
                else if(level == 2)
                {
                    picbox.Image = Image.FromFile("pic2.png");
                }
                else if(level == 3)
                {
                    picbox.Image = Image.FromFile("pic3.jpg");
                }
                else if(level == 4)
                {
                    picbox.Image = Image.FromFile("pic4.jpg");
                }
                else if(level == 5)
                {
                    picbox.Image = Image.FromFile("pic5.jpg");
                }
                else if(level == 6)
                {
                    picbox.Image = Image.FromFile("pic6.jpg");
                }
                else if(level == 7)
                {
                    picbox.Image = Image.FromFile("pic7.jpg");
                }
                else if(level == 8)
                {
                    picbox.Image = Image.FromFile("pic8.jpg");
                }
                else if(level == 9)
                {
                    picbox.Image = Image.FromFile("pic9.jpg");
                }
                else if(level == 10)
                {
                    picbox.Image = Image.FromFile("pic10.jpg");
                }
                else if(level == 11)
                {
                    picbox.Image = Image.FromFile("pic11.jpg");
                }
                else if(level == 12)
                {
                    picbox.Image = Image.FromFile("pic12.png");
                }
                else if(level == 13)
                {
                    picbox.Image = Image.FromFile("pic13.jpg");
                }
                else if(level == 14)
                {
                    picbox.Image = Image.FromFile("pic14.jpg");
                }
                else if(level == 15)
                {
                    picbox.Image = Image.FromFile("pic15.png");
                }
                else if(level == 16)
                {
                    picbox.Image = Image.FromFile("pic16.jpg");
                }
                else if(level == 17)
                {
                    picbox.Image = Image.FromFile("pic17.jpg");
                }
                else if(level == 18)
                {
                    picbox.Image = Image.FromFile("pic18.gif");
                }
                else if(level == 19)
                {
                    picbox.Image = Image.FromFile("pic19.png");
                }
                else if(level == 20)
                {
                    picbox.Image = Image.FromFile("pic20.jpg");
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
    }
}
