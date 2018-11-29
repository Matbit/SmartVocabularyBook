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
        private static List<LanguageModel> listLanguageModel = new List<LanguageModel>();

        public UserModification(Main main)
        {
            InitializeComponent();
            frmMain = main;
            findAllLanguages();

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
    }
}
