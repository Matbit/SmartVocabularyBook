using SmartVocabularyBook.vcbook.controller;
using SmartVocabularyBook.vcbook.model;
using SmartVocabularyBook.vcbook.service;
using System;
using System.Collections;
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
    public partial class ProgressManager : Form
    {

        private Main frmMain;
        private ProgressController progressController = new ProgressController();
        private List<Vocabulary> myVocs = new List<Vocabulary>();
        private DBController dbController = new DBController();
        private static VocabularyService service = new VocabularyService();


        public ProgressManager(Main aMain)
        {
            InitializeComponent();
            frmMain = aMain;
            addVocToListView();
        }

        public void addVocToListView()
        {
            listViewAllVocab.Items.Clear();
            List<Vocabulary> resultList = new List<Vocabulary>();
            resultList = service.findAll();  

            foreach (Vocabulary aVoc in resultList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = aVoc.getWordLang1();
                item.SubItems.Add(aVoc.getWordLang2());
                item.SubItems.Add(aVoc.getMemo());

                listViewAllVocab.Items.Add(item);
                

            }

            
        }

        

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnOpenMain_Click(object sender, EventArgs e)
        {
            frmMain.Show();
            this.Close();
        }

        private void btnClearEntries_Click(object sender, EventArgs e)
        {
            clearAllTextboxes();
        }

        private void btnAddVocabulary_Click(object sender, EventArgs e)
        {
            progressController = new ProgressController();
            progressController.validateNewVocabulary(tbxMainLang.Text, tbxSecondLang.Text, tbxNote.Text);
            clearAllTextboxes();
            addVocToListView();

        }

        private void clearAllTextboxes()
        {
            tbxMainLang.Clear();
            tbxNote.Clear();
            tbxSecondLang.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            lbxDBResult.Items.Clear();
            if (string.IsNullOrEmpty(tbxSearch.Text))
            {
                return;
            }


            try
            {
                List<Vocabulary> vocabularies = service.findAllBySearchTerm(tbxSearch.Text);

                foreach (Vocabulary vocabulary in vocabularies)
                {
                    lbxDBResult.Items.Add(vocabulary.getWordLang1());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //List<Vocabulary> myVocabulary = new List<Vocabulary>();
            Vocabulary vc = new Vocabulary();
            //myVocabulary = progressController.validateSearchInFormProgressManager(tbxSearch.Text);
            //vc = progressController.validateSearchInFormProgressManager(tbxSearch.Text);

            //try
            //{
            //    lbxDBResult.Items.Add(vc.getWordLang1());
            //}
            //catch
            //{
            //    return;
            //}
        }

        private void btnSearchWord_Click(object sender, EventArgs e)
        {
            lbxDBResult.Items.Clear();
            if (string.IsNullOrEmpty(tbxSearch.Text))
            {
                return;
            }


            try
            {
                List<Vocabulary> vocabularies = service.findAllBySearchTerm(tbxSearch.Text);

                foreach(Vocabulary vocabulary in vocabularies)
                {
                    lbxDBResult.Items.Add(vocabulary.getWordLang1());
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            //List<Vocabulary> myVocabulary = new List<Vocabulary>();
            Vocabulary vc = new Vocabulary();
            //myVocabulary = progressController.validateSearchInFormProgressManager(tbxSearch.Text);
            //vc = progressController.validateSearchInFormProgressManager(tbxSearch.Text);

            //try
            //{
            //    lbxDBResult.Items.Add(vc.getWordLang1());
            //}
            //catch
            //{
            //    return;
            //}
               
            
        }

        private void lbxDBResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewAllVocab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
