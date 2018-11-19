﻿using SmartVocabularyBook.src.model;
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

        public GuiTestAnalysis(Main main, List<TestVocabularyModel> list)
        {   
            InitializeComponent();
            frmMain = main;
            resultList = list;
            setDataGrid();
        }

        private void setDataGrid()
        {
            dataGridResult.DataSource = resultList;

            //specific columns settings
            dataGridResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridResult.Columns[0].ReadOnly = true;
            dataGridResult.Columns[0].HeaderText = "Gesuchtes Wort";
            dataGridResult.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridResult.Columns[1].ReadOnly = true;
            dataGridResult.Columns[1].HeaderText = "Lösung";            
            dataGridResult.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridResult.Columns[2].ReadOnly = true;
            dataGridResult.Columns[2].HeaderText = "Meine Eingabe";
            dataGridResult.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridResult.Columns[3].ReadOnly = true;
            //dataGridResult.Columns[3].HeaderText = "Punkte";
            //dataGridResult.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid style setup
            dataGridResult.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            dataGridResult.Font = new Font("Microsoft Sans Serif", 12);

            dataGridResult.BackgroundColor = Color.Khaki;
            dataGridResult.DefaultCellStyle.ForeColor = Color.Black;
            dataGridResult.DefaultCellStyle.BackColor = Color.Beige;
            
        }

        private void GuiTestAnalysis_Load(object sender, EventArgs e)
        {

        }
    }
}
