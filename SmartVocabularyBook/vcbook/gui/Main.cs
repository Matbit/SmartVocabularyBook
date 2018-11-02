using SmartVocabularyBook.vcbook.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartVocabularyBook
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            openPanelMain();
        }

        public void openPanelMain()
        {
            this.panelMain.Controls.Clear();
            GuiMain main = new GuiMain(this);
            main.TopLevel = false;
            main.AutoScroll = true;
            this.panelMain.Controls.Add(main);
            main.Show();

        }

        public void openPanelProgressManager()
        {
            this.panelMain.Controls.Clear();
            ProgressManager frm = new ProgressManager(this);
            frm.TopLevel = false;
            frm.AutoScroll = true;
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }



        public void setPanelMainVisible()
        {
            openPanelMain();
        }

        
        private void btnLearningProcess_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            exitApplication();
        }

        private void exitApplication()
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
