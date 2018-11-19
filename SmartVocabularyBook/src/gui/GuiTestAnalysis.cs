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
        //private static List<TestResult> trList = new List<TestResult>();
        private static TestResult trStatic = new TestResult();
        private static int points = 0;

        public GuiTestAnalysis(Main main, List<TestVocabularyModel> list)
        {   
            InitializeComponent();
            frmMain = main;
            resultList = list;
            calcPoints();
            setDataGrid();
            setGrade();
            saveTestResultInDB();
            lTestResult.Text = points + " (von " + resultList.Count + ") Punkten erreicht! "+ (resultList.Count - points)+" Fehler ";
        }

        private void setDataGrid()
        {
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
            trStatic.setId(-1);
            trStatic.setScores(points);
            trStatic.setWrongAnswers(resultList.Count - points);
            trStatic.setMemo(" ");

            try
            {
                testservice.insertTest(trStatic);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double calcGradeInProcent()
        {
            return testservice.calcGradeInProcent(resultList.Count, points);
        }

        private String getGradeAsString(double procent)
        {
            if(procent > 95)
            {
                trStatic.setGrade(1);
                return "1+";
            }
            else if(procent > 89)
            {
                trStatic.setGrade(1);
                return "1";
            }
            else if(procent > 84)
            {
                trStatic.setGrade(2);
                return "2+";
            }
            else if(procent > 79)
            {
                trStatic.setGrade(2);
                return "2";
            }
            else if(procent > 74)
            {
                trStatic.setGrade(2);
                return "2-";
            }
            else if(procent > 69)
            {
                trStatic.setGrade(3);
                return "3+";
            }
            else if(procent > 64)
            {
                trStatic.setGrade(3);
                return "3";
            }
            else if(procent > 59)
            {
                trStatic.setGrade(3);
                return "3-";
            }
            else if(procent > 54)
            {
                trStatic.setGrade(4);
                return "4+";
            }
            else if(procent > 49)
            {
                trStatic.setGrade(4);
                return "4";
            }
            else if(procent > 46)
            {
                trStatic.setGrade(4);
                return "4-";
            }
            else if(procent > 44)
            {
                trStatic.setGrade(5);
                return "5+";
            }
            else if(procent > 39)
            {
                trStatic.setGrade(5);
                return "5";
            }
            else if(procent > 33)
            {
                trStatic.setGrade(5);
                return "5-";
            }
            else
            {
                trStatic.setGrade(6);
                return "6";
            }
                        
        }

        private void setGrade()
        {
            double grade = calcGradeInProcent();
            String gradeAsString = getGradeAsString(grade);
            lGrade.Text = gradeAsString;

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
            //clear list when all datas are saved in db
            resultList.Clear();
            points = 0;
            //open new form
            frmMain.openPanelProgressManager();
        }
    }
}
