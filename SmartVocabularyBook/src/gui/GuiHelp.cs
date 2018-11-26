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
    public partial class GuiHelp : Form
    {
        Main frmMain;
        public GuiHelp(Main main)
        {
            InitializeComponent();
            frmMain = main;
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
    }
}
