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
            loadHelpFile();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void loadHelpFile()
        {
            
            string line = "";
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader("Hilfe.txt", Encoding.Default);
                while ((line = file.ReadLine()) != null)
                {
                    //tbxShowHelp.AppendText(line + Environment.NewLine);
                    rtbxHelpText.AppendText(line + Environment.NewLine);                    
                }
                file.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
