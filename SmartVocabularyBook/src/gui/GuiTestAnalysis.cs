using SmartVocabularyBook.src.model;
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
