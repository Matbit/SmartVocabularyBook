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
    public partial class AnalysisGui : Form
    {
        Main frmMain;
        private static TestService testService = new TestService();
        private static List<TestResult> resultList = new List<TestResult>();

        public AnalysisGui(Main main)
        {
            InitializeComponent();
            frmMain = main;
            loadTests();
            setDataGrid();
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

            //specific columns settings
            dataGridAllTests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

            dataGridAllTests.Columns[0].Visible = false;
            dataGridAllTests.Columns[5].Visible = false;
            dataGridAllTests.Columns[6].Visible = false;

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
