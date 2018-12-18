using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartVocabularyBook.src.gui
{
    public partial class AnalysisGui : Form
    {
        Main frmMain;
        private static TestService testService = new TestService();
        private static InformationService serviceInformation = new InformationService();
        private static List<TestResultView> resultList = new List<TestResultView>();
        private static List<int> helpingList = new List<int>();
        private static List<String> dateFormatList = new List<String>();

        public AnalysisGui(Main main)
        {
            InitializeComponent();
            frmMain = main;
            loadTests();
            setDataGrid();
            //formatDateView();
        }

        private int getUserId()
        {
            List<Information> info = serviceInformation.getInformation();
            return info[0].userId;
        }

        private void formatDateView()
        {
            dataGridAllTests.Columns[1].CellTemplate.ValueType = typeof(String);
            foreach (var c in resultList)
            {
                //helpingList.Add(c.getTestDate());
            }
            for(int i = 0; i < helpingList.Count; i++)
            {

                String dateString2 = helpingList[i].ToString();
               
                //MessageBox.Show(testdate.ToString());
               

               // dateFormatList.Add(newDate);
                
            }

            for(int i = 0; i < dateFormatList.Count; i++)
            {
                dataGridAllTests.Rows[i].Cells[1].Value = dateFormatList[i];
            }
            
        }

        private void loadTests()
        {
            try
            {
                resultList = testService.findAllTests(getUserId());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       
        private void setDataGrid()
        {
            dataGridAllTests.DataSource = resultList;

            


            dataGridAllTests.Columns[0].Visible = false;
            dataGridAllTests.Columns[5].Visible = false;
            //dataGridAllTests.Columns[6].Visible = false;
            //dataGridAllTests.Columns[7].Visible = false;

            //specific columns settings
            dataGridAllTests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridAllTests.Columns[0].ReadOnly = true;
            dataGridAllTests.Columns[0].HeaderText = "Datum";
            dataGridAllTests.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridAllTests.Columns[1].ReadOnly = true;
            dataGridAllTests.Columns[1].HeaderText = "Datum";
            dataGridAllTests.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridAllTests.Columns[2].ReadOnly = true;
            dataGridAllTests.Columns[2].HeaderText = "Punkte";
            dataGridAllTests.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridAllTests.Columns[3].ReadOnly = true;
            dataGridAllTests.Columns[3].HeaderText = "Anzahl Fehler";
            dataGridAllTests.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridAllTests.Columns[4].ReadOnly = true;
            dataGridAllTests.Columns[4].HeaderText = "Note";
            dataGridAllTests.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            


            //datagrid style
            dataGridAllTests.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dataGridAllTests.Font = new Font("Microsoft Sans Serif", 12);
            dataGridAllTests.RowHeadersVisible = false;
            dataGridAllTests.BackgroundColor = Color.Khaki;
            dataGridAllTests.DefaultCellStyle.ForeColor = Color.Black;
            dataGridAllTests.DefaultCellStyle.BackColor = Color.Beige;
        }

        private void AnalysisGui_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenVocabularyView_Click(object sender, EventArgs e)
        {
            frmMain.openPanelProgressManager();
        }

        private void btnLast10Entries_Click(object sender, EventArgs e)
        {
            getLastTestResults(10);
           
        }

        private void btnShowAllTests_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridAllTests.DataSource = testService.findAllTests(getUserId());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLast25Tests_Click(object sender, EventArgs e)
        {
            getLastTestResults(20);
        }

        private void getLastTestResults(int limit)
        {
            try
            {
                dataGridAllTests.DataSource = testService.findLastTests(limit, getUserId());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLast30Tests_Click(object sender, EventArgs e)
        {
            getLastTestResults(30);
        }

        private void btnMaxPoints_Click(object sender, EventArgs e)
        {
            if (resultList.Count < 1)
            {
                return;
            }

            //points
            int maxPoints = 0;

            for (int i = 0; i < resultList.Count; i++)
            {
                if(resultList[i].getScores() > maxPoints)
                {
                    maxPoints = resultList[i].getScores();
                }
            }

            lResultPoints.Text = "Maximale Punkte: "+maxPoints.ToString();
            lResultPoints.Visible = true;

            //mistakes
            int minMistakes = 110;

            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].getWrongAnswers() < minMistakes)
                {
                    minMistakes = resultList[i].getWrongAnswers();
                }
            }

            lResultCountMistakes.Text = "Wenigste Fehler: " + minMistakes.ToString();
            lResultCountMistakes.Visible = true;

            //grade

            int grade = 7;

            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].getGrade() < grade)
                {
                    grade = resultList[i].getGrade();
                }
            }

            lResultGrade.Text = "Beste Note: " + grade.ToString();
            lResultGrade.Visible = true;
        }

        private void btnMinimumPoints_Click(object sender, EventArgs e)
        {   
            if(resultList.Count < 1)
            {
                return;
            }


            //points
            int minPoints = 110;

            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].getScores() < minPoints)
                {
                    minPoints = resultList[i].getScores();
                }
            }

            lResultPoints.Text = "Minimale Punkte: " + minPoints.ToString();
            lResultPoints.Visible = true;

           

            //mistakes
            int mistakes = 0;

            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].getWrongAnswers() > mistakes)
                {
                    mistakes = resultList[i].getWrongAnswers();
                }
            }

            lResultCountMistakes.Text = "Maximale Fehler: " + mistakes.ToString();
            lResultCountMistakes.Visible = true;

            //grade
            int minGrade = 0;

            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].getGrade() > minGrade)
                {
                    minGrade = resultList[i].getGrade();
                }
            }

            lResultGrade.Text = "Schlechteste Note: " + minGrade.ToString();
            lResultGrade.Visible = true;

        }

        private void btnAvgPoints_Click(object sender, EventArgs e)
        {

            if (resultList.Count < 1)
            {
                return;
            }


            //points
            double avg = 0;
            double sum = 0;

            for (int i = 0; i < resultList.Count; i++)
            {
                sum += resultList[i].getScores();
            }
            avg = Math.Round(sum / resultList.Count, 2);
            
            lResultPoints.Text = "Durchschnitt: " + avg.ToString();
            lResultPoints.Visible = true;

            //mistakes
            double avgMistakes = 0;
            double sumMistakes = 0;

            for (int i = 0; i < resultList.Count; i++)
            {
                sumMistakes += resultList[i].getWrongAnswers();
            }
            avgMistakes = Math.Round(sumMistakes / resultList.Count, 2);
            lResultCountMistakes.Text = "Durchschnitt: " + avgMistakes.ToString();
            lResultCountMistakes.Visible = true;

            //grade
            double avgGrade = 0;
            double sumGrade = 0;

            for (int i = 0; i < resultList.Count; i++)
            {
                sumGrade += resultList[i].getGrade();
            }

            avgGrade = Math.Round(sumGrade / resultList.Count, 2);
            lResultGrade.Text = "Durchschnitt: " + avgGrade.ToString();
            lResultGrade.Visible = true;
        }
    }
}
