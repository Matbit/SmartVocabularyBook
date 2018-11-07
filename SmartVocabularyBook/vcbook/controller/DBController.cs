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
        private const String dbFile = "svb.db";

        public void initDB()
        {
            if (!doesDBExists())
                SQLiteConnection.CreateFile(dbFile);

            createTableVocabulary();
            createTableUser();
            createTableTest();            
        }

        private bool doesDBExists()
        {
           return File.Exists(dbFile);
        }

        private void createTableVocabulary()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile+";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS vocabulary(id INTEGER PRIMARY KEY AUTOINCREMENT, wordLang1 TEXT NOT NULL, wordLang2 TEXT NOT NULL, memo TEXT, dateOfCreation TEXT NOT NULL, lastCall TEXT, archived INTEGER NOT NULL)";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void createTableUser()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS user(id INTEGER PRIMARY KEY AUTOINCREMENT, nickname TEXT NOT NULL, mainLanguage TEXT NOT NULL, lastTest TEXT, lastLogin TEXT);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void createTableTest()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS test(id INTEGER PRIMARY KEY AUTOINCREMENT, dateTest TEXT NOT NULL, score INTEGER NOT NULL);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool insertNewVocabulary(Vocabulary vc, String date, int archived)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
                con.Open();
                string sql = "INSERT INTO vocabulary(wordLang1, wordLang2, memo, dateOfCreation, archived) VALUES ('" + vc.getWordLang1() + "', '" + vc.getWordLang2() +
                            "', '" + vc.getMemo() + "', '" + date + "', '" + archived+ "')";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public List<Vocabulary> getAllVocabularies()
        {

            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
                con.Open();
                string sql = "SELECT * FROM vocabulary;";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                List<Vocabulary> myVocs = new List<Vocabulary>();
               
                while (reader.Read())
                {
                    myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString()));
                }
                con.Close();

                return myVocs;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                List<Vocabulary> myVocs = new List<Vocabulary>();
                return myVocs;
            }
        }

        public Vocabulary getOneVocabulary(String word)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
                con.Open();
                string sql = "SELECT * FROM vocabulary WHERE wordLang1 LIKE '"+word+"%';";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                                               
                SQLiteDataReader reader = cmd.ExecuteReader();

                List<Vocabulary> myVocs = new List<Vocabulary>();
                Vocabulary vc = new Vocabulary();

                while (reader.Read())
                {
                    //myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), (int)reader["id"]));

                    string idAsString = reader["id"].ToString();
                    long idAsLong = 0L;
                    long.TryParse(idAsString, out idAsLong);
                  

                    vc = new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong);
                }
                con.Close();

                return vc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR", MessageBoxButtons.OK);
                //List<Vocabulary> myVocs = new List<Vocabulary>();
                Vocabulary vc = new Vocabulary();
                return vc;
            }
        

        }



    }
}
