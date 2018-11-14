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

            createTableVocabulary();
            createTableUser();
            createTableTest();            
        }

        //returns a boolean whether a file exists
        private bool doesDBExists()
        {
           return File.Exists(dbFile);
        }

        //creates a vocabulary table. Just called by constructor
        private void createTableVocabulary()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile+";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS vocabulary(id INTEGER PRIMARY KEY AUTOINCREMENT, wordLang1 TEXT NOT NULL, wordLang2 TEXT NOT NULL, memo TEXT, dateOfCreation TEXT NOT NULL, lastCall TEXT, archived INTEGER NOT NULL)";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

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

        //creates a test table. Just called by constructor
        private void createTableTest()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS test(id INTEGER PRIMARY KEY AUTOINCREMENT, dateTest TEXT NOT NULL, score INTEGER NOT NULL);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        

    }
}
