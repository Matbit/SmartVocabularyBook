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
    public partial class Options : Form
    {

        Main frmMain;

        public Options(Main main)
        {
            InitializeComponent();
            frmMain = main;
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColorBackground_Click(object sender, EventArgs e)
        {
              if( colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
              
        }
    }
}
