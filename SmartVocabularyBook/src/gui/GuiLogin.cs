﻿using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartVocabularyBook.src.gui
{
    public partial class GuiLogin : Form
    {
        Main frmMain;

        private static UserService serviceuser = new UserService();
        static LanguageService servicelanguage = new LanguageService();
        private static InformationService serviceInformation = new InformationService();
        private List<User> listUser = new List<User>();
        static UserService serviceUser = new UserService();
        private static List<LanguageModel> listLanguageModel = new List<LanguageModel>();
        

        public GuiLogin(Main main)
        {
            InitializeComponent();
            frmMain = main;
            setlbxUser();
            setGroupBox(false);
            findAllLanguages();
        }

        private void setGroupBox(bool isActive)
        {
            gbxAddUser.Visible = isActive;
        }

        //load languages in listbox
        private void findAllLanguages()
        {
            listLanguageModel.Clear();
            listLanguageModel = servicelanguage.findAll();

            for (int i = 0; i < listLanguageModel.Count; i++)
            {
                lbxLanguages.Items.Add(listLanguageModel[i].languageName);
            }
        }

        private void setlbxUser()
        {
            listUser.Clear();
            listUser = serviceuser.findAll();

            for(int i = 0; i < listUser.Count; i++)
            {
                lbxUser.Items.Add(listUser[i].nickname);
            }

            lbxUser.SelectedIndex = 0;
        }

        private void GuiLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(lbxUser.SelectedItems.Count < 1)
            {
                MessageBox.Show("Wähle bitte einen Nutzer aus.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(lbxUser.SelectedItems.Count > 0)
            {
                int index = lbxUser.SelectedIndex;
                int userId = index + 1;

                serviceInformation.updateInformation(new Information(userId));

                //MessageBox.Show(userId.ToString());

                frmMain.openPanelMain();
            }


        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!gbxAddUser.Visible)
                setGroupBox(true);
            else
            {
                setGroupBox(false);
                tbxNickname.Clear();
                lbxLanguages.ClearSelected();                
            }
        }

        private void btnAddUserToDB_Click(object sender, EventArgs e)
        {   
            if(tbxNickname.TextLength < 2)
            {
                MessageBox.Show("Dein Nickname muss mindestens zwei Buchstaben enthalten.","Hinweis",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(lbxLanguages.SelectedIndex < 0)
            {
                MessageBox.Show("Bitte klicke auf deine Muttersprache", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            User newUser = new User();
            newUser.nickname = tbxNickname.Text;            
            newUser.mainLanguage = lbxLanguages.SelectedItem.ToString();
            if (serviceUser.insertIntoUser(newUser))
            {
                lbxUser.Items.Clear();
                setlbxUser();
                MessageBox.Show("Neuen Account erfolgreich angelegt", "Glückwunsch!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setGroupBox(false);
                tbxNickname.Clear();
                lbxLanguages.ClearSelected();
            }

            
        }
    }
}
