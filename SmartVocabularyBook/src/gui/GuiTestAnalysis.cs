using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.service;
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
    public partial class GuiTestAnalysis : Form
    {
        Main frmMain;
        private static TestService testservice = new TestService();
        private static List<TestVocabularyModel> resultList = new List<TestVocabularyModel>();
        private static List<TestResult> trList = new List<TestResult>();
        private static int points = 0;

        public GuiTestAnalysis(Main main, List<TestVocabularyModel> list)
        {   
            InitializeComponent();
            frmMain = main;
            resultList = list;
            calcPoints();
            setDataGrid();
            saveTestResultInDB();
            setGrade();
            lTestResult.Text = points + " (von " + resultList.Count + ") Punkten erreicht! "+ (resultList.Count - points)+" Fehler ";

            //clear list when all datas are saved in db
        }

        private void setDataGrid()
        {
            convertResultListToTestResult();
            dataGridResult.DataSource = resultList;

            //specific columns settings
            dataGridResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridResult.Columns[0].ReadOnly = true;
            dataGridResult.Columns[0].HeaderText = "Gesuchtes Wort";
            dataGridResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridResult.Columns[1].ReadOnly = true;
            dataGridResult.Columns[1].HeaderText = "Lösung";            
            dataGridResult.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridResult.Columns[2].ReadOnly = true;
            dataGridResult.Columns[2].HeaderText = "Meine Eingabe";
            dataGridResult.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridResult.Columns[3].ReadOnly = true;
            dataGridResult.Columns[3].HeaderText = "Punkte";
            dataGridResult.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid style
            dataGridResult.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dataGridResult.Font = new Font("Microsoft Sans Serif", 12);
            dataGridResult.RowHeadersVisible = false;
            dataGridResult.BackgroundColor = Color.Khaki;
            dataGridResult.DefaultCellStyle.ForeColor = Color.Black;
            dataGridResult.DefaultCellStyle.BackColor = Color.Beige;
            
        }

        private void saveTestResultInDB()
        {
            //TestResult tr = new()
        }

        private double calcGradeInProcent()
        {
            return testservice.calcGradeInProcent(resultList.Count, points);
        }

        private String getGradeAsString(double procent)
        {
            if(procent > 95)
            {
                return "1+";
            }
            else if(procent > 89)
            {
                return "1";
            }
            else if(procent > 84)
            {
                return "2+";
            }
            else if(procent > 79)
            {
                return "2";
            }
            else if(procent > 74)
            {
                return "2-";
            }
            else if(procent > 69)
            {
                return "3+";
            }
            else if(procent > 64)
            {
                return "3";
            }
            else if(procent > 59)
            {
                return "3-";
            }
            else if(procent > 54)
            {
                return "4+";
            }
            else if(procent > 49)
            {
                return "4";
            }
            else if(procent > 46)
            {
                return "4-";
            }
            else if(procent > 44)
            {
                return "5+";
            }
            else if(procent > 39)
            {
                return "5";
            }
            else if(procent > 33)
            {
                return "5-";
            }
            else
            {
                return "6";
            }
                        
        }

        private void setGrade()
        {
            double grade = calcGradeInProcent();
            String gradeAsString = getGradeAsString(grade);
            lGrade.Text = gradeAsString;

        }

        private void convertResultListToTestResult()
        {
            //result list contains given word, solution and user input

        }

        private void calcPoints()
        {
            points = 0;
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].getWord2().Equals(resultList[i].getUserWord()))
                {
                    resultList[i].setScore(1);
                    points++;
                }
                else resultList[i].setScore(0);
            }
        }

        private void GuiTestAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void btnGoOn_Click(object sender, EventArgs e)
        {
            frmMain.openPanelProgressManager();
        }
    }
}
