using System;
using System.Drawing;
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
            lResultCount.Visible = false;
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

        private void btnSearchWord_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbxSearch.Text))
            {
                lResultCount.Text = "0 Treffer";
                lResultCount.Visible = true;
                return;
            }
            if(tbxSearch.TextLength < 3)
            {
                lResultCount.Text = " Suche erst ab 3 Buchstaben.";
                lResultCount.Visible = true;
                return;
            }

            rtbxHelpText.SelectAll();
            rtbxHelpText.SelectionBackColor = Color.LightGreen;

            int index = 0;
            int count = 0;
            while (index < rtbxHelpText.Text.LastIndexOf(tbxSearch.Text))
            {
                rtbxHelpText.Find(tbxSearch.Text, index, rtbxHelpText.TextLength, RichTextBoxFinds.None);
                rtbxHelpText.SelectionBackColor = Color.Yellow;
                index = rtbxHelpText.Text.IndexOf(tbxSearch.Text, index) + 1;
                count++;
            }


            lResultCount.Text =  count+ " Treffer";
            lResultCount.Visible = true;
        }

        
    }
}
