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
    public partial class ProgressManager : Form
    {

        private Main frmMain;
        private ProgressController progressController;

        public ProgressManager(Main aMain)
        {
            InitializeComponent();
            frmMain = aMain;
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

        }

        private void clearAllTextboxes()
        {
            tbxMainLang.Clear();
            tbxNote.Clear();
            tbxSecondLang.Clear();
        }
    }
}
