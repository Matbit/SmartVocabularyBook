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
        static InformationService serviceInformation = new InformationService();
        private static List<LanguageModel> listLanguageModel = new List<LanguageModel>();

        public UserModification(Main main)
        {
            InitializeComponent();
            frmMain = main;
            findAllLanguages();
            findUserData();
            
        }

        //load languages in listbox
        private void findAllLanguages()
        {
            listLanguageModel.Clear();
            listLanguageModel = servicelanguage.findAll();
            
                    

            for(int i = 0; i < listLanguageModel.Count;i++)
            {
                lbxSelectLanguage.Items.Add(listLanguageModel[i].languageName);
                lbxSelectForeignLanguage.Items.Add(listLanguageModel[i].languageName);
            }
        }

        //load user data
        private void findUserData()
        {
            List<Information> myList = serviceInformation.getInformation();

            try
            {
                User user = serviceUser.findUserById(getUserId());
                lCurrentNickname.Text = user.nickname;
                lCurrentLanguage.Text = user.mainLanguage;
                lCurrentForeignLanguage.Text = user.foreignLanguage;
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
            string choosenForeignLanguage = "";

            //main language
            if(tbxAnyLanguage.TextLength < 1 && lbxSelectLanguage.SelectedIndex != -1)
            {
                choosenLanguage = lbxSelectLanguage.SelectedItem.ToString();
                lCurrentLanguage.Text = choosenLanguage;
            }
            else if(lbxSelectLanguage.SelectedIndex < 0 && tbxAnyLanguage.TextLength > 0)
            {
                lCurrentLanguage.Text = tbxAnyLanguage.Text;                                
            }

            //foreign language
            if (tbxAnyForeignLanguage.TextLength < 1 && lbxSelectForeignLanguage.SelectedIndex != -1)
            {
                choosenForeignLanguage = lbxSelectForeignLanguage.SelectedItem.ToString();
                lCurrentForeignLanguage.Text = choosenForeignLanguage;
            }
            else if (lbxSelectForeignLanguage.SelectedIndex < 0 && tbxAnyForeignLanguage.TextLength > 0)
            {
                lCurrentForeignLanguage.Text = tbxAnyForeignLanguage.Text;
            }

            if (tbxNickname.TextLength > 0)
            {
                lCurrentNickname.Text = tbxNickname.Text;
            }
            
            //clear all tbx
            tbxAnyLanguage.Clear();
            tbxNickname.Clear();
            tbxAnyForeignLanguage.Clear();
        }

        private void btnSaveUserData_Click(object sender, EventArgs e)
        {
            List<Information> myList = serviceInformation.getInformation();            

            User user = new User(lCurrentNickname.Text, lCurrentLanguage.Text, myList[0].userId, lCurrentForeignLanguage.Text);

            try
            {
                serviceUser.updateUserById(user);
                frmMain.setWelcomeText(user.id);
                frmMain.openPanelMain();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {   
            DialogResult dr = MessageBox.Show("Es werden alle zu deinem Account zugehörigen Vokabeln unwiderruflich gelöscht.\nBist du dir wirklich sicher?",
                "Achtung!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
            {
                serviceUser.deleteUserById(getUserId());
                frmMain.openPanelLogin();
                MessageBox.Show("Der Account wurde erfolgreich gelöscht.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
