using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.service;
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
        //contains the solution of the test
        private static List<Vocabulary> listSolution = new List<Vocabulary>();
        
        //contains all vocabularies which should be answered by the user
        private static List<TestVocabularyModel> testList = new List<TestVocabularyModel>();
        
        //services
        private static VocabularyService vocabularyService = new VocabularyService();
        private static TestSettingsService testSettingsService = new TestSettingsService();

        public GuiTest(Main main)
        {
            InitializeComponent();
            frmMain = main;
            createTestList();
            setDataGrid();
                                    
        }

        private void GuiTest_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setDataGrid()
        {
            listSolution.Clear();
            testList.Clear();
            listSolution = vocabularyService.findAllActivated();
            TestVocabularyModel tm = new TestVocabularyModel();

            foreach (var vc in listSolution)
            {
                tm = new TestVocabularyModel(vc.getWordLang1(), " ");
                testList.Add(tm);
            }

            dataGridTest.DataSource = testList;
            dataGridTest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTest.Columns[0].ReadOnly = true;
            dataGridTest.Columns[0].HeaderText = "Gesuchtes Wort";
            dataGridTest.Columns[1].HeaderText = "Lösung";
            dataGridTest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridTest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridTest.BackgroundColor = Color.Khaki;
            dataGridTest.DefaultCellStyle.ForeColor = Color.DarkGreen;
            dataGridTest.DefaultCellStyle.BackColor = Color.Beige;
            dataGridTest.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dataGridTest.Font = new Font("Microsoft Sans Serif", 13);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Der Test wurde abgebrochen.");
            frmMain.openPanelProgressManager();
        }

        private void createTestList()
        {
            TestSetup ts = testSettingsService.getTestSettingsById(1);
            
            int searchMode = ts.getSearchMode();
            int givenLang = ts.getGivenLang();
            int count = ts.getCount();

            if(searchMode == 1)
            {
                if(givenLang == 1)
                {
                    listSolution = vocabularyService.findAllNewestActiveVocabularies(count);
                    
                }
            }
        }





        private void GuiTest_Load_1(object sender, EventArgs e)
        {

        }
    }
}
