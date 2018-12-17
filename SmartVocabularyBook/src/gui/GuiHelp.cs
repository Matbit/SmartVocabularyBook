using System;
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
            //loadHelpFile();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void loadHelpFile()
        {

            string path = Properties.Resources.Hilfe;
            path = path.Replace(@"/", @"\");

            try
            {
                
                
               // rtbxHelpText.Text = File.ReadAllText("\resources\\Hilfe.txt", Encoding.Default);


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void rtbxHelpText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
