using SmartVocabularyBook.src.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.repository
{
    class TestSettingsRepository
    {
        //name of sqlite file
        private const String dbFile = "svb.db";
        
        //creates table test
        public bool createTableTestSettings()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS testSettings(id INTEGER PRIMARY KEY AUTOINCREMENT, searchMode TEXT NOT NULL, count INTEGER NOT NULL, givenLang TEXT NOT NULL, saved INTEGER NOT NULL);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //insert new test setup
        public bool insertTestSettings(TestSetup ts, int isSaved)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "INSERT INTO testSettings(searchMode, count, givenLang, saved) VALUES ('"+ts.getSearchMode()+"','"+ts.getCount()+"','"+
                        ts.getGivenLang()+"','"+isSaved+"');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

    }
}
