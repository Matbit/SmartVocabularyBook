using SmartVocabularyBook.src.model;
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
    public partial class UserModification : Form
    {
        Main frmMain;
        static LanguageService servicelanguage = new LanguageService();
        static UserService serviceUser = new UserService();
        private static List<LanguageModel> listLanguageModel = new List<LanguageModel>();

        public UserModification(Main main)
        {
            InitializeComponent();
            frmMain = main;
            findAllLanguages();
            findUserData();

            //mtbxNewPassword.TextLength
        }

        //load languages in listbox
        private void findAllLanguages()
        {
            listLanguageModel.Clear();
            listLanguageModel = servicelanguage.findAll();
            
                    

            for(int i = 0; i < listLanguageModel.Count;i++)
            {
                lbxSelectLanguage.Items.Add(listLanguageModel[i].languageName);
            }
        }

        //load user data
        private void findUserData()
        {   

            try
            {
                User user = serviceUser.findUserById(new User(1));
                lCurrentNickname.Text = user.nickname;
                lCurrentLanguage.Text = user.mainLanguage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void gr_Load(object sender, EventArgs e)
        {

        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            frmMain.openPanelMain();
        }

        private void tbxAnyLanguage_TextChanged(object sender, EventArgs e)
        {
            lbxSelectLanguage.ClearSelected();
        }

        private void btnConfirmMainLanguage_Click(object sender, EventArgs e)
        {
            string choosenLanguage = "";
            string choosenNickname = "";

            if(tbxAnyLanguage.TextLength < 1 && lbxSelectLanguage.SelectedIndex != -1)
            {
                choosenLanguage = lbxSelectLanguage.SelectedItem.ToString();
                lCurrentLanguage.Text = choosenLanguage;
            }
            else if(lbxSelectLanguage.SelectedIndex < 0 && tbxAnyLanguage.TextLength > 0)
            {
                lCurrentLanguage.Text = tbxAnyLanguage.Text;                                
            }

            if(tbxNickname.TextLength > 0)
            {
                lCurrentNickname.Text = tbxNickname.Text;
            }
            
            //clear all tbx
            tbxAnyLanguage.Clear();
            tbxNickname.Clear();
        }

        private void btnSaveUserData_Click(object sender, EventArgs e)
        {
            User user = new model.User(lCurrentNickname.Text, lCurrentLanguage.Text, 1);

            try
            {
                serviceUser.updateUserById(user);
                frmMain.openPanelMain();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
