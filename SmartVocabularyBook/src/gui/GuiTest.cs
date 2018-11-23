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
        //contains the correct word, which was looked for
        private static List<Vocabulary> solutionWordList = new List<Vocabulary>();
                    
        //contains all vocabularies which should be answered by the user
        private static List<TestVocabularyModel> testList = new List<TestVocabularyModel>();

        //contains all vocabularies which the user has answered
        private static List<TestVocabularyModel> userInput = new List<TestVocabularyModel>();

        //result list contains given word, solution and user input
        private static List<TestVocabularyModel> resultList = new List<TestVocabularyModel>();

        //scored points for every each word
        private static List<int> score = new List<int>();
        
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

        private void setDataGrid()
        {
            dataGridTest.DataSource = testList;
            dataGridTest.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTest.Columns[0].ReadOnly = true;
            dataGridTest.Columns[0].HeaderText = "Gesuchtes Wort";
            dataGridTest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridTest.Columns[1].HeaderText = "Lösung";
            dataGridTest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridTest.Columns[2].Visible = false;
            dataGridTest.Columns[3].Visible = false;
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


        //creates a new list in data grid
        private void createTestList()
        {
            testList.Clear();
            listSolution.Clear();
            solutionWordList.Clear();
            TestSetup ts = testSettingsService.getTestSettingsById(1);          

            int searchMode = ts.getSearchMode();

            if (searchMode == 1)
            {
                listSolution = vocabularyService.findAllNewestActiveVocabularies(ts.getCount());
                updateLastCall(listSolution);
                setLanguageMode(ts);               
            }
            else if(searchMode == 2)
            {
                listSolution = vocabularyService.findOldestActiveVocabularies(ts.getCount());
                updateLastCall(listSolution);
                setLanguageMode(ts);
            }
            else if(searchMode == 3)
            {
                listSolution = vocabularyService.findRandomActiveVocabularies(ts.getCount());
                updateLastCall(listSolution);
                setLanguageMode(ts);
            }
            else if(searchMode == 4)
            {
                listSolution = vocabularyService.findLastCallASCVocabularies(ts.getCount());
                updateLastCall(listSolution);
                setLanguageMode(ts);
            }

        }

        private void setLanguageMode(TestSetup ts)
        {
            int givenLang = ts.getGivenLang();
            int count = ts.getCount();
            TestVocabularyModel tm = new TestVocabularyModel();
            Vocabulary vocabulary = new Vocabulary();

            if (givenLang == 1)
            {
                foreach (Vocabulary vc in listSolution)
                {
                    tm = new TestVocabularyModel(vc.getWordLang1(), " ");
                    vocabulary = new Vocabulary(vc.getWordLang2());
                    testList.Add(tm);
                    solutionWordList.Add(vocabulary);
                }
            }
            else if (givenLang == 2)
            {
                foreach (var vc in listSolution)
                {
                    tm = new TestVocabularyModel(vc.getWordLang2(), " ");
                    vocabulary = new Vocabulary(vc.getWordLang1());
                    testList.Add(tm);
                    solutionWordList.Add(vocabulary);
                }
            }
            else if (givenLang == 3)
            {
                Random rd = new Random();

                for (int i = 0; i < count; i++)
                {
                    int random = rd.Next(0, 100);

                    if (random > 49)
                    {
                        tm = new TestVocabularyModel(listSolution[i].getWordLang1(), " ");
                        vocabulary = new Vocabulary(listSolution[i].getWordLang2());
                        testList.Add(tm);
                        solutionWordList.Add(vocabulary);
                    }
                    else
                    {
                        tm = new TestVocabularyModel(listSolution[i].getWordLang2(), " ");
                        vocabulary = new Vocabulary(listSolution[i].getWordLang1());                        
                        testList.Add(tm);
                        solutionWordList.Add(vocabulary);
                    }
                }
            }
        }

        private void updateLastCall(List<Vocabulary> myList)
        {
            DateTime today = DateTime.Today;
            string dateAsString = today.Year + "" + today.Month + "" + today.Day + "";
            int lastCall = Int32.Parse(dateAsString);
            foreach (var vc in myList)
            {
                vc.setLastCall(lastCall);
                vocabularyService.updateLastCallById(vc);
            }            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchtest Du den Test wirklich beenden?", "Frage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                setTestLists();
                calcPoints();
                frmMain.openPanelTestAnalysis(resultList);
            }
        }

        private void setTestLists()
        {
            TestSetup ts = testSettingsService.getTestSettingsById(1);

           for(int i = 0; i<dataGridTest.Rows.Count; i++)
            {
                userInput.Add(new TestVocabularyModel(dataGridTest[1, i].Value.ToString() , " "));
            }

           for(int i = 0; i < testList.Count; i++)
            {   

                resultList.Add(new TestVocabularyModel(testList[i].getWord1(), solutionWordList[i].getWordLang1(), userInput[i].getWord1()));
            }

            userInput.Clear();           
        }

        private void calcPoints()
        {
            score.Clear();
            for(int i = 0; i < listSolution.Count; i++)
            {
                if (resultList[i].getWord2().Equals(resultList[i].getUserWord()))
                {
                    score.Add(1);
                }
                else score.Add(0);                
            }  
        }

        private void dataGridTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
