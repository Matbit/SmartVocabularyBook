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
    public partial class GuiLogin : Form
    {
        Main frmMain;

        private static UserService serviceuser = new UserService();
        private List<User> listUser = new List<User>();

        public GuiLogin(Main main)
        {
            InitializeComponent();
            frmMain = main;
            setlbxUser();
        }

        private void setlbxUser()
        {
            listUser = serviceuser.findAll();

            for(int i = 0; i < listUser.Count; i++)
            {
                lbxUser.Items.Add(listUser[i].nickname);
            }

            lbxUser.SelectedIndex = 0;
        }

        private void GuiLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(lbxUser.SelectedItems.Count < 1)
            {
                MessageBox.Show("Wähle bitte einen Nutzer aus.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }
    }
}
