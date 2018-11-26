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
                resultList = testService.findAllTests();
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
    }
}
