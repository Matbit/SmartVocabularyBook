using SmartVocabularyBook.src.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.repository
{
    public class LanguageRepository
    {
        private const String dbFile = "svb.sqlite";
        //create Language 
        public bool createTableLanguage()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS language(id INTEGER PRIMARY KEY AUTOINCREMENT,languageName TEXT NOT NULL);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //insert into language
        public bool insertIntoLanguage(string name)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "INSERT INTO language(languageName) VALUES ('" + name + "');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //update language
        public bool updateLanguageById(LanguageModel lm)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE language SET languageName ='" + lm.languageName + "' WHERE id = '" + lm.id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //find all entries
        public List<LanguageModel> findAll()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM language;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<LanguageModel> listLanguage = new List<LanguageModel>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                int id = Int32.Parse(idAsString);

                listLanguage.Add(new LanguageModel(id, reader["languageName"].ToString()));
            }
            con.Close();
            return listLanguage;
        }

        //find single language by id
        public LanguageModel findLanguageById(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM language WHERE id = '"+ id+"';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            LanguageModel lm = new LanguageModel();

            while (reader.Read())
            {
               LanguageModel lm2 = new LanguageModel(id, reader["languageName"].ToString());
                lm = lm2;
            }
            con.Close();
            return lm;
        }
    }
}
