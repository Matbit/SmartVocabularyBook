using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;
using SmartVocabularyBook.vcbook.model;
using SmartVocabularyBook.vcbook.service;
using SmartVocabularyBook.src.service;

namespace SmartVocabularyBook.vcbook.controller
{
   class DBController
    {
        //name of sqlite file
        private const String dbFile = "svb.db";

        //static member
        static VocabularyService serviceVocabulary = new VocabularyService();
        static UserService serviceUser = new UserService();
        static TestSettingsService serviceTestSettings = new TestSettingsService();
        static TestService serviceTest = new TestService();

        //method is called by the constructor of "main" class
        public void initDB()
        {
            if (!doesDBExists())
                SQLiteConnection.CreateFile(dbFile);

            try
            {
                //create all tables
                serviceVocabulary.createTableVocabulary();
                serviceTest.createTableTest();
                serviceTestSettings.createTableTestSettings();
                serviceUser.createTableUser();

                //initial entries
                initialTestSetup();
                initialUser();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                        
        }

        //initial user
        private void initialUser()
        {
            if (serviceUser.findAll().Count < 1)
            {
                serviceUser.initialUser();
            }
        }

        //initial testsetup
        private void initialTestSetup()
        {
            if(serviceTestSettings.findAll().Count < 1)
            {
                serviceTestSettings.initialTestSetup();
            }
        }

        //returns a boolean whether a file exists
        private bool doesDBExists()
        {
           return File.Exists(dbFile);
        }

    }
}
