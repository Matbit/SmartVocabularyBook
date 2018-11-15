using SmartVocabularyBook.src.model;
using SmartVocabularyBook.vcbook.model;
using SmartVocabularyBook.vcbook.service;
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
    public partial class GuiTest : Form
    {
        Main frmMain;

        private static List<Vocabulary> listSolution = new List<Vocabulary>();
        private static List<TestVocabularyModel> testList = new List<TestVocabularyModel>();
        private static VocabularyService vocabularyService = new VocabularyService();
        public GuiTest(Main main)
        {
            InitializeComponent();
            frmMain = main;
                        
        }

        private void GuiTest_Load(object sender, EventArgs e)
        {
            listSolution = vocabularyService.findAllActivated();
            TestVocabularyModel tm = new TestVocabularyModel();

            foreach (var vc in listSolution)
            {
                tm = new TestVocabularyModel(vc.getWordLang1(), " ");
                testList.Add(tm);

                               
                //listView1.Items.Add(tm.word1);
            }

            //dataGridTest.Dock = DockStyle.Fill;
            
            dataGridTest.DataSource = testList;
            dataGridTest.Columns[0].ReadOnly = true;
            dataGridTest.Columns[0].HeaderText = "Gesuchtes Wort";
            dataGridTest.Columns[1].HeaderText = "Lösung";
            dataGridTest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridTest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridTest.BackgroundColor = Color.Khaki;
            //dataGridTest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dataGridTest.Columns.

            
            
        }

        private void dataGridTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
