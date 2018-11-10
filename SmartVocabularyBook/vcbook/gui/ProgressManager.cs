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
        //private List<Vocabulary> myVocs = new List<Vocabulary>();
        private DBController dbController = new DBController();
        private static VocabularyService service = new VocabularyService();
        private static Vocabulary staticVocabulary = new Vocabulary();
        private static List<Vocabulary> staticVocabularyList = new List<Vocabulary>();


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
            resultList = service.findAllActivated();
            

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
                //does voc already exists?
                if (!doesVocabularyExits(staticVocabulary))
                {   
                    addVocabulary(tbxMainLang.Text, tbxSecondLang.Text, tbxNote.Text);
                    addVocToListView();
                }
                else
                {
                    if (isVocabularyArchived(staticVocabulary))
                    {   
                        //set archived status false if voc exists -> so, user could see voc in list
                        Vocabulary vc = service.findVocabularyByWord(staticVocabulary.getWordLang1());
                        service.updateArchivedStatusById(vc, 0);
                        addVocToListView();
                        MessageBox.Show("Vokabel wurde aus dem Archiv zu Ihren aktiven Vokabeln hinzugefügt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else MessageBox.Show("Vokabel ist bereits vorhanden.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                

            }            
            clearAllTextboxes();
            

        }

        private void clearAllTextboxes()
        {
            tbxMainLang.Clear();
            tbxNote.Clear();
            tbxSecondLang.Clear();
            tbxDataMemo.Clear();
            tbxDataMainLang.Clear();
            tbxDataSecondLang.Clear();
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
            clearAllTextboxes();
            staticVocabularyList.Clear();

            
                if (!string.IsNullOrEmpty(tbxSearch.Text))
                {
                    try
                    {
                        
                        if (rbtnMainLang.Checked)
                        {
                            staticVocabularyList = service.findAllBySearchTerm(tbxSearch.Text, true);
                        }
                        else  staticVocabularyList = service.findAllBySearchTerm(tbxSearch.Text, false);


                    foreach (Vocabulary vocabulary in staticVocabularyList)
                        {
                        if (rbtnMainLang.Checked)
                        {
                            lbxDBResult.Items.Add(vocabulary.getWordLang1());
                        }
                        else
                        {
                            lbxDBResult.Items.Add(vocabulary.getWordLang2());
                        }

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
                // bool mainLanguage = rbtnMainLang.Checked;
                //staticVocabulary = service.findVocabularyByWordList(word);
                int index = lbxDBResult.SelectedIndex;
                Vocabulary result = new Vocabulary();
                result = staticVocabularyList[index];

                tbxDataMainLang.Text = result.getWordLang1();
                    tbxDataSecondLang.Text = result.getWordLang2();
                    tbxDataMemo.Text = result.getMemo();
               
                
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

        //add vocabulary to database
        private void addVocabulary(String word1, String word2, String memo)
        {
            word1 = word1.Trim();
            word2 = word2.Trim();
            memo = memo.Trim();

            Vocabulary vc = new Vocabulary(word1, word2, memo);

            String date = vc.getDateOfCreation().ToString();
            int archived;
            if (vc.isArchived())
                archived = 1;
            else archived = 0;


            try
            {
                service.insertVocabulary(vc, date, archived);
                MessageBox.Show("Neue Vokabel wurde erfolgreich hinzugefügt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message + " \nEingabe war leider nicht erfolgreich. Überprüfen Sie Ihre Angaben.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        //validate if vocabulary still exists
        private bool doesVocabularyExits(Vocabulary newVocabulary)
        {   
            //returns an empty object if there are no result
            Vocabulary vc = service.findVocabularyByWord(newVocabulary.getWordLang1());
            if (!string.IsNullOrEmpty(vc.getWordLang1()))
            {
                if (vc.getWordLang2().Equals(newVocabulary.getWordLang2()))
                    return true;   
            }
            return false;
            
        }

        //validate if vocabulary is archived
        private bool isVocabularyArchived(Vocabulary newVocabulary)
        {
            Vocabulary vc = service.findVocabularyByWord(newVocabulary.getWordLang1());
            if (!string.IsNullOrEmpty(vc.getWordLang1()))
            {
                if (vc.isArchived())
                {
                    return true;
                }
                    
            }
            return false;

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
                addVocToListView();
                clearAllTextboxes();
                MessageBox.Show("Vokabel wurde erfolgreich geändert");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //delete vocabulary from database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String word = lbxDBResult.SelectedItem.ToString();

            try
            {
                staticVocabulary = service.findVocabularyByWord(word);

                DialogResult dr = MessageBox.Show("Möchten Sie diesen Vokabelsatz wirklich löschen?\n" + staticVocabulary.getWordLang1() + " - " +
                         staticVocabulary.getWordLang2(), "Frage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    if (service.deleteVocabularyById(staticVocabulary))
                    {
                        addVocToListView();
                        clearAllTextboxes();
                        tbxSearch.Text = "";
                        MessageBox.Show("Vokabelsatz \"" + staticVocabulary.getWordLang1() + "\" wurde erfolgreich gelöscht.");                        
                    }
                    
                }
                else
                {                       
                    clearAllTextboxes();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            
        }

        //archived vocabulary
        private void btnArchived_Click(object sender, EventArgs e)
        {
            String word = lbxDBResult.SelectedItem.ToString();

            try
            {
                staticVocabulary = service.findVocabularyByWord(word);

                DialogResult dr = MessageBox.Show("Möchten Sie diesen Vokabelsatz wirklich archivieren?\n" + staticVocabulary.getWordLang1() + " - " +
                         staticVocabulary.getWordLang2(), "Frage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {   
                    //set 1 because vocabulary should be archived
                    if (service.updateArchivedStatusById(staticVocabulary, 1))
                    {
                        addVocToListView();
                        clearAllTextboxes();
                        tbxSearch.Text = "";
                        MessageBox.Show("Vokabelsatz \"" + staticVocabulary.getWordLang1() + "\" wurde erfolgreich archiviert.");
                    }

                }
                else
                {
                    clearAllTextboxes();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void llOpenBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String url = "https://www.dict.cc";

            try
            {
                browser.Visible = true;
                browser.Navigate(url);
                llClose.Visible = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void llClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            stopBrowser();
        }

        public void stopBrowser()
        {
            browser.Stop();
            browser.Visible = false;
            llClose.Visible = false;
        }
    }
}
