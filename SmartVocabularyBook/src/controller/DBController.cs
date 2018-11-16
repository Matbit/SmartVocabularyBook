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


        public void initDB()
        {
            if (!doesDBExists())
                SQLiteConnection.CreateFile(dbFile);

            //create all tables
            VocabularyService serviceVocabulary = new VocabularyService();
            serviceVocabulary.createTableVocabulary();
            TestService serviceTest = new TestService();
            serviceTest.createTableTest();
            TestSettingsService serviceTestSettings = new TestSettingsService();
            serviceTestSettings.createTableTestSettings();
            
            createTableUser();
                        
        }

        //returns a boolean whether a file exists
        private bool doesDBExists()
        {
           return File.Exists(dbFile);
        }

        
        //creates an user table. Just called by constructor
        private void createTableUser()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS user(id INTEGER PRIMARY KEY AUTOINCREMENT, nickname TEXT NOT NULL, mainLanguage TEXT NOT NULL, lastTest TEXT, lastLogin TEXT);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
             

        

    }
}
