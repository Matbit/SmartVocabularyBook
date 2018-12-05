using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.service;
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
        //controller and services
        //private DBController dbController = new DBController();
        private static VocabularyService service = new VocabularyService();
        private static TestSettingsService testSettingsService = new TestSettingsService();
        


        private static Vocabulary staticVocabulary = new Vocabulary();
        private static Vocabulary selectedVocabulary = new Vocabulary();
        private static List<Vocabulary> staticVocabularyList = new List<Vocabulary>();
        private static List<Vocabulary> listVocabularyActiveView = new List<Vocabulary>();
        private static List<Vocabulary> listVocabularyArchivedView = new List<Vocabulary>();


        public ProgressManager(Main aMain)
        {
            InitializeComponent();
            frmMain = aMain;
            addVocToListView();
            setBtnActive(false);
            setBtnDelete(false);
            setBtnArchived(true);
            lNameView.Text = "Meine Vokabeln";
            //testSettingsService.updateTestSettings(ts, 1);
            loadTestSettings();
            lLSearchWordInWeb.Visible = false;
            changeReadOnlyTbxEditVocabulary(true);
            staticVocabulary.setUserId(1);

        }

        private void loadTestSettings()
        {
            TestSetup ts = testSettingsService.getTestSettingsById(1);
            int searchMode = ts.getSearchMode();
            int count = ts.getCount();
            int givenLang = ts.getGivenLang();
            bool isSaved = ts.getSave();

            if (searchMode == 1)
            {
                rbtnNewestVocabulary.Checked = true;
            }
            else if (searchMode == 2)
            {
                rbtnOldestVocabulary.Checked = true;
            }
            else if (searchMode == 3)
            {
                rbtnRandomVocabulary.Checked = true;
            }
            else rbtnLongTermNotAskedVocabulary.Checked = true;

            trbCountVocabulary.Value = count;

            if (givenLang == 1)
            {
                rbtnTestMainLang.Checked = true;
            }
            else if (givenLang == 2)
            {
                rbtnTestSecondLang.Checked = true;
            }
            else rbtnTestRandomLang.Checked = true;

            if (!isSaved)
            {
                chbxSaveSettings.Checked = false;
            }
        }

        private void changeReadOnlyTbxEditVocabulary(bool isReadOnly)
        {
            tbxDataMainLang.ReadOnly = isReadOnly;
            tbxDataSecondLang.ReadOnly = isReadOnly;
            tbxDataMemo.ReadOnly = isReadOnly;
        }

        public void addVocToListView()
        {
            listViewAllVocab.Items.Clear();
            listVocabularyActiveView.Clear();
            List<Vocabulary> resultList = null;
            resultList = service.findAllActivated();
            listVocabularyActiveView = resultList;            
            

            foreach (Vocabulary aVoc in resultList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = aVoc.getWordLang1();
                item.SubItems.Add(aVoc.getWordLang2());
                item.SubItems.Add(aVoc.getMemo());

                listViewAllVocab.Items.Add(item);
            }
        }

        public void addArchivedVocToListView()
        {
            listViewAllVocab.Items.Clear();
            listVocabularyArchivedView.Clear();
            List<Vocabulary> resultList;
            resultList = service.findAllArchived();
            listVocabularyArchivedView = resultList;


            foreach (Vocabulary aVoc in resultList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = aVoc.getWordLang1();
                item.SubItems.Add(aVoc.getWordLang2());
                item.SubItems.Add(aVoc.getMemo());

                listViewAllVocab.Items.Add(item);
            }
        }

        private void setBtnActive(bool isActive)
        {
            btnSetVocabularyActive.Visible = isActive;
        }

        private void setBtnDelete(bool isActive)
        {
            btnDeleteVocabulary.Visible = isActive;
        }

        private void setBtnArchived(bool isArchived)
        {
            btnSetVocabularyArchived.Visible = isArchived;
        }

        private void btnShowActiveVocabularies_Click(object sender, EventArgs e)
        {
            lNameView.Text = "Meine Vokabeln";
            addVocToListView();
            setBtnActive(false);
            setBtnDelete(false);
            setBtnArchived(true);
        }

        private void btnShowArchivedVocabularies_Click(object sender, EventArgs e)
        {
            lNameView.Text = "Archivierte Vokabeln";
            addArchivedVocToListView();
            setBtnActive(true);
            setBtnDelete(true);
            setBtnArchived(false);            
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
            tbxSearch.Clear();
            lLSearchWordInWeb.Visible = false;
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
            //clearAllTextboxes();
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
            //abort if nothing is selected
            if (lbxDBResult.SelectedIndex == -1)
                return;

            try
            {
                int index = lbxDBResult.SelectedIndex;
                Vocabulary result = new Vocabulary();
                result = staticVocabularyList[index];
                selectedVocabulary = result;

                tbxDataMainLang.Text = result.getWordLang1();
                    tbxDataSecondLang.Text = result.getWordLang2();
                    tbxDataMemo.Text = result.getMemo();
                changeReadOnlyTbxEditVocabulary(false);
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

            //set userId
            vc.setUserId(1);

            String date = vc.getDateOfCreation().ToString();
            int archived;
            if (vc.isArchived())
                archived = 1;
            else archived = 0;

            try
            {
                service.insertVocabulary(vc, date, archived, vc.getUserId());
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
            staticVocabularyList = service.findVocabularyByWordList(newVocabulary.getWordLang1());

            foreach(var vocabularies in staticVocabularyList)
            {
                if (!string.IsNullOrEmpty(vocabularies.getWordLang1()))
                {
                    if (vocabularies.getWordLang2().Equals(newVocabulary.getWordLang2()))
                        return true;
                }
            }
            
            return false;            
        }

        //validate if vocabulary is archived
        private bool isVocabularyArchived(Vocabulary newVocabulary)
        {
            staticVocabularyList.Clear();
            staticVocabularyList = service.findVocabularyByWordList(newVocabulary.getWordLang1());

            foreach(var vocabularies in staticVocabularyList)
            {
                if (!string.IsNullOrEmpty(vocabularies.getWordLang1()))
                {
                    if (vocabularies.isArchived())
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }

        private void listViewAllVocab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveWord_Click(object sender, EventArgs e)
        {
            if (validateNewVocabulary(tbxDataMainLang.Text, tbxDataSecondLang.Text, tbxDataMemo.Text))
            {

                try
                {
                    staticVocabulary.setId(selectedVocabulary.getId());
                    service.updateVocabularyById(staticVocabulary);
                    addArchivedVocToListView();
                    addVocToListView();
                    clearAllTextboxes();
                    changeReadOnlyTbxEditVocabulary(true);
                    MessageBox.Show("Vokabel wurde erfolgreich geändert");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        //delete vocabulary from database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            String word = "";
            try
            {
                word = lbxDBResult.SelectedItem.ToString();
            }
            catch
            {
                //do nothing
                //return;
            }
            

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
            changeReadOnlyTbxEditVocabulary(true);            
        }

        //archived vocabulary
        private void btnArchived_Click(object sender, EventArgs e)
        {
            String word = "";

            try
            {
                word = lbxDBResult.SelectedItem.ToString();
            }
            catch
            {
                // do nothing
            }

            

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
            changeReadOnlyTbxEditVocabulary(true);
        }

        private void llOpenBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const String url = "https://www.dict.cc";

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
            lLSearchWordInWeb.Visible = false;
        }

        private void trbCountVocabulary_Scroll(object sender, EventArgs e)
        {
            tbxSetValueOfAskedVocabulary.Text = trbCountVocabulary.Value.ToString();
        }

        private void mtbxSetValueOfAskedVocabulary_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            trbCountVocabulary.Value = Int32.Parse(tbxSetValueOfAskedVocabulary.Text);
        }

        private void btnSetVocabularyActive_Click(object sender, EventArgs e)
        {
            activateSelectedArchivedVocabulary();
        }

        private void activateSelectedArchivedVocabulary()
        {
            if (listViewAllVocab.SelectedItems.Count > 0)
            {
                int index = listViewAllVocab.FocusedItem.Index;
                Vocabulary vc = new Vocabulary();
                vc = listVocabularyArchivedView[index];
                service.updateArchivedStatusById(vc, 0);
                addArchivedVocToListView();
                MessageBox.Show("Vokabel erfolgreich aktiviert.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Es wurde keine Vokabel ausgewählt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void btnSetVocabularyArchived_Click(object sender, EventArgs e)
        {

            if (listViewAllVocab.SelectedItems.Count > 0)
            {
                int index = listViewAllVocab.FocusedItem.Index;
                Vocabulary vc = new Vocabulary();
                vc = listVocabularyActiveView[index];
                service.updateArchivedStatusById(vc, 1);
                addArchivedVocToListView();
                addVocToListView();
                MessageBox.Show("Vokabel erfolgreich achiviert.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Es wurde keine Vokabel ausgewählt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStartTraining_Click(object sender, EventArgs e)
        {
            startTraining();
        }

        private void startTraining()
        {
            frmMain.openPanelTest();

        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            setTestSettings();
            startTest();

            TestSetup test = new TestSetup();
            test = testSettingsService.getTestSettingsById(1);
            //just for tests
            //MessageBox.Show(test.getId() + " " + test.getSearchMode() + " " + test.getCount() + " " + test.getGivenLang() + " " + test.getSave());
        }

        private void startTest()
        {
            frmMain.openPanelTest();
        }

        private void setTestSettings()
        {
            int searchMode = 0;
            int givenLanguage = 0;
            int isSaved = 0;
            
            if (rbtnNewestVocabulary.Checked)
            {
                searchMode = 1;
            }
            else if (rbtnOldestVocabulary.Checked)
            {
                searchMode = 2;
            }
            else if (rbtnRandomVocabulary.Checked)
            {
                searchMode = 3;
            }
            else if (rbtnLongTermNotAskedVocabulary.Checked)
            {
                searchMode = 4;
            }

            if (rbtnTestMainLang.Checked)
            {
                givenLanguage = 1;
            }
            else if (rbtnTestSecondLang.Checked)
            {
                givenLanguage = 2;
            }
            else if (rbtnTestRandomLang.Checked)
            {
                givenLanguage = 3;
            }

            if (chbxSaveSettings.Checked)
            {
                isSaved = 1;
            }            

            TestSetup tsNew = new TestSetup(1L, searchMode, trbCountVocabulary.Value, givenLanguage, chbxSaveSettings.Checked);

            if (chbxSaveSettings.Checked)
            {
                testSettingsService.updateTestSettings(tsNew, isSaved);
            }
            else
            {
                testSettingsService.updateSaveOption(0);
            }



        }

        private void trbCountVocabulary_ValueChanged(object sender, EventArgs e)
        {
            tbxSetValueOfAskedVocabulary.Text = trbCountVocabulary.Value.ToString();
        }

        private void lLSearchWordInWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            String text = tbxMainLang.Text;

            if (text.Contains("ü"))
            {
                text = text.Replace('ü', 'u');
            }
            if (text.Contains("ö"))
            {
                
            }

            string stringUrl = "https://www.dict.cc/?s=" + tbxMainLang.Text;
            String url = stringUrl;

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

        private void tbxMainLang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbxMainLang.TextLength >= 2)
            {   
                //deactivated, because of problems with "ä,ö,ü"
                //lLSearchWordInWeb.Visible = true;
            }
            else lLSearchWordInWeb.Visible = false;
        }

        private void tbxMainLang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteVocabulary_Click(object sender, EventArgs e)
        {

            try
            {

                if (listViewAllVocab.SelectedItems.Count > 0)
                {
                    int index = listViewAllVocab.FocusedItem.Index;
                    Vocabulary vc = new Vocabulary();
                    vc = listVocabularyArchivedView[index];
                    DialogResult dr = MessageBox.Show("Möchten Sie diesen Vokabelsatz wirklich löschen?\n" + vc.getWordLang1() + " - " +
                        vc.getWordLang2(), "Frage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        if (service.deleteVocabularyById(vc))
                        {
                            addVocToListView();
                            addArchivedVocToListView();
                            clearAllTextboxes();
                            MessageBox.Show("Vokabelsatz \"" + vc.getWordLang1() + "\" wurde erfolgreich gelöscht.");
                        }
                    }
                }
                else MessageBox.Show("Es wurde keine Vokabel ausgewählt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }  
    }
}
