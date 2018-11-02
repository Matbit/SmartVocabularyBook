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
    public partial class GuiMain : Form
    {
        private Main frmMain;
        public GuiMain(Main main)
        {
            InitializeComponent();
            frmMain = main;
        }

        private void GuiMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLearningProgress_Click(object sender, EventArgs e)
        {
            openGuiProgressManager();
        }

        private void openGuiProgressManager()
        {
            frmMain.openPanelProgressManager();
            
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
