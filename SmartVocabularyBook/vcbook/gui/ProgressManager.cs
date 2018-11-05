using SmartVocabularyBook.vcbook.controller;
using SmartVocabularyBook.vcbook.model;
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
        private ProgressController progressController;
        private List<Vocabulary> myVocs;
        private DBController dbController = new DBController();

        public ProgressManager(Main aMain)
        {
            InitializeComponent();
            frmMain = aMain;
            addVocToListView();
        }

        public void addVocToListView()
        {
            myVocs = dbController.getAllVocabularies();

            //ListViewItem item = new ListViewItem();

            

            foreach (Vocabulary aVoc in myVocs)
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
    }
}
