﻿using System;
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
    public partial class UserModification : Form
    {
        Main frmMain;
        public UserModification(Main main)
        {
            InitializeComponent();
            frmMain = main;
        }

        private void gr_Load(object sender, EventArgs e)
        {

        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            frmMain.openPanelMain();
        }
    }
}
