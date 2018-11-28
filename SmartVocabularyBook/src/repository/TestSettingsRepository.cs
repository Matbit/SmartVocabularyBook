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
            string sql = "CREATE TABLE IF NOT EXISTS testSettings(id INTEGER PRIMARY KEY AUTOINCREMENT, searchMode INTEGER NOT NULL, count INTEGER NOT NULL, givenLang INTEGER NOT NULL, saved INTEGER NOT NULL);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //insert new test setup
        public bool updateTestSettings(TestSetup ts, int isSaved)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE testSettings SET searchMode = '"+ts.getSearchMode()+"', count = '"+ts.getCount()+"', givenLang = '"+
                        ts.getGivenLang()+"', saved = '"+isSaved+"' WHERE id = 1;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //update save option
        public bool updateSaveOption(int isSaved)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE testSettings SET saved = '" + isSaved + "' WHERE id = 1;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //get saved
        public int getisSavedById(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();

            string sql = "SELECT saved FROM testSettings WHERE id = " + id + ";";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            TestSetup ts = new TestSetup();

            int isSaved = -1;
            while (reader.Read())
            {
                string isSavedAsString = reader["saved"].ToString();
                int.TryParse(isSavedAsString, out isSaved);
            }
            return isSaved;
        }



        //get test settings
        public TestSetup getTestSettingsById(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();

            string sql = "SELECT * FROM testSettings WHERE id = " + id + ";";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            TestSetup ts = new TestSetup();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string saved = reader["saved"].ToString();
                bool savedAsBool = false;
                int isSaved = -1;
                int.TryParse(saved, out isSaved);

                if(isSaved == 1)
                {
                    savedAsBool = true;
                }   

                string searchMode = reader["searchmode"].ToString();
                int searchModeAsInt = 0;
                int.TryParse(searchMode, out searchModeAsInt);

                string countAsString = reader["count"].ToString();
                int count = 0;
                int.TryParse(countAsString, out count);

                string givenLangAsString = reader["givenLang"].ToString();
                int givenLang = 0;
                int.TryParse(givenLangAsString, out givenLang);

                TestSetup ts2 = new TestSetup(idAsLong, searchModeAsInt, count, givenLang, savedAsBool);
                ts = ts2;
            }

            return ts;
        }

        //insert setup into db
        public bool insertSetUpIntoDB(TestSetup ts)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();

            string sql ="INSERT INTO testSettings(searchMode, count, givenLang, saved) VALUES ('"+ts.getSearchMode()+"', '"+ ts.getCount()+"', '"+ ts.getGivenLang()+
                "', '"+ ts.getSave() + "');";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public List<TestSetup> findAll()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();

            string sql = "SELECT * FROM testSettings;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<TestSetup> listSetup = new List<TestSetup>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string savedAsString = reader["saved"].ToString();
                bool saved = false;
                bool.TryParse(savedAsString, out saved);

                string searchAsString = reader["searchMode"].ToString();
                int search = Int32.Parse(searchAsString);

                string countAsString = reader["count"].ToString();
                int count = Int32.Parse(countAsString);

                string givenLangAsString = reader["givenLang"].ToString();
                int givenLang = Int32.Parse(givenLangAsString);

                listSetup.Add(new TestSetup(idAsLong, search, count, givenLang, saved));
            }
            con.Close();
            return listSetup;

        }

    }
}
