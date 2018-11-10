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
        private List<Vocabulary> myVocs = new List<Vocabulary>();
        private DBController dbController = new DBController();
        private static VocabularyService service = new VocabularyService();
        private static Vocabulary staticVocabulary = new Vocabulary();


        public ProgressManager(Main aMain)
        {
            InitializeComponent();
            frmMain = aMain;
            addVocToListView();
        }

        public void addVocToListView()
        {
            listViewAllVocab.Items.Clear();
            List<Vocabulary> resultList;
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
            //when user input is alright, then add word to database
            if(validateNewVocabulary(tbxMainLang.Text, tbxSecondLang.Text, tbxNote.Text))
            {
                addVocabulary(tbxMainLang.Text, tbxSecondLang.Text, tbxNote.Text);
                addVocToListView();
            }            
            clearAllTextboxes();
            

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

        //search by user
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            lbxDBResult.Items.Clear();

            
                if (!string.IsNullOrEmpty(tbxSearch.Text))
                {
                    try
                    {
                        List<Vocabulary> vocabularies;
                        if (rbtnMainLang.Checked)
                        {
                            vocabularies = service.findAllBySearchTerm(tbxSearch.Text, true);
                        }
                        else  vocabularies = service.findAllBySearchTerm(tbxSearch.Text, false);


                    foreach (Vocabulary vocabulary in vocabularies)
                        {   
                            if(rbtnMainLang.Checked)
                                lbxDBResult.Items.Add(vocabulary.getWordLang1());
                                else lbxDBResult.Items.Add(vocabulary.getWordLang2());

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
            
        }

        private void btnSearchWord_Click(object sender, EventArgs e)
        {
            //button is currently unused
               
            
        }

        private void lbxDBResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            String word = lbxDBResult.SelectedItem.ToString();

            try
            {
                staticVocabulary = service.findVocabularyByWord(word);
                tbxDataMainLang.Text = staticVocabulary.getWordLang1();
                tbxDataSecondLang.Text = staticVocabulary.getWordLang2();
                tbxDataMemo.Text = staticVocabulary.getMemo();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private bool validateNewVocabulary(String word1, String word2, String memo)
        {
            word1 = word1.Trim();
            word2 = word2.Trim();
            memo = memo.Trim();

            if (string.IsNullOrEmpty(word1))
            {
                MessageBox.Show("Hauptsprache muss ausgefüllt werden", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(word2))
            {
                MessageBox.Show("Übersetzung muss ausgefüllt werden", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(memo))
            {
                memo = " ";                
            }

            staticVocabulary.setWordLang1(word1);
            staticVocabulary.setWordLang2(word2);
            staticVocabulary.setMemo(memo);

            return true;
                      
        }

        private void addVocabulary(String word1, String word2, String memo)
        {
            word1 = word1.Trim();
            word2 = word2.Trim();
            memo = memo.Trim();

            Vocabulary vc = new Vocabulary(word1, word2, memo);

            String date = vc.getDateOfCreation().ToString();
            int archived;
            if (vc.isArchived())
                archived = 0;
            else archived = 1;

            bool ok = service.insertVocabulary(vc, date, archived);
            if (!ok)
                MessageBox.Show("Eingabe war leider nicht erfolgreich. Überprüfen Sie Ihre Angaben.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ok)
                MessageBox.Show("Neue Vokabel wurde erfolgreich hinzugefügt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void listViewAllVocab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            validateNewVocabulary(tbxDataMainLang.Text, tbxDataSecondLang.Text, tbxDataMemo.Text);
            
            try
            {
                service.updateVocabularyById(staticVocabulary);
                MessageBox.Show("Vokabel wurde erfolgreich geändert");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
