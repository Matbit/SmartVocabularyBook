using SmartVocabularyBook.vcbook.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.vcbook.repository
{
    class VocabularyRepository
    {

        private const String dbFile = "svb.db";


        //creates a vocabulary table
        public bool createTableVocabulary()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS vocabulary(id INTEGER PRIMARY KEY AUTOINCREMENT, wordLang1 TEXT NOT NULL, wordLang2 TEXT NOT NULL, memo TEXT, dateOfCreation TEXT NOT NULL, lastCall TEXT, archived INTEGER NOT NULL, userId INTEGER NOT NULL)";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }


        //finds all vocabularies in database
        public List<Vocabulary> findAll()
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

        //finds all vocabularies which are not archived
        public List<Vocabulary> findAllArchived(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE archived = 1 AND userId = '" + id + "' ORDER BY UPPER(wordLang1) ASC;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string archivedAsString = reader["archived"].ToString();
                bool archivedAsBool = false;
                bool.TryParse(archivedAsString, out archivedAsBool);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool));
            }
            con.Close();

            return myVocs;
        }

        //finds all vocabularies which are archived
        public List<Vocabulary> findAllActivated(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE archived = 0 AND  userId = '" + id + "' ORDER BY UPPER(wordLang1) ASC;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string archivedAsString = reader["archived"].ToString();
                bool archivedAsBool = false;
                bool.TryParse(archivedAsString, out archivedAsBool);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool));
            }
            con.Close();

            return myVocs;
        }


        //finds all vocabularies by parameter
        public List<Vocabulary> findAllBySearchTerm(String word, bool isMainLanguage, int id)
        {
            string sql = "";

            if (isMainLanguage)
            {
                sql = "SELECT * FROM vocabulary WHERE (wordLang1 LIKE '" + word + "%') AND archived = 0 AND userId = '" + id + "';";
            }
            else
            {
                sql = "SELECT * FROM vocabulary WHERE (wordLang2 LIKE '" + word + "%') AND archived = 0 AND userId = '" + id + "';";
            }

            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string archivedAsString = reader["archived"].ToString();
                bool archivedAsBool = false;
                bool.TryParse(archivedAsString, out archivedAsBool);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool));
            }
            con.Close();

            return myVocs;
        }

        //method to find one vocabulary
        public Vocabulary findVocabularyByWord(String word, int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE wordLang1 = '" + word + "' AND userId = '" + id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader reader = cmd.ExecuteReader();

            Vocabulary vc;
            Vocabulary vocabulary = new Vocabulary();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                bool archivedAsBool = false;
                string archivedAsString = reader["archived"].ToString();
                if (archivedAsString.Equals("1"))
                {
                    archivedAsBool = true;
                }                
                //bool.TryParse(archivedAsString, out archivedAsBool);

                vc = new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool );
                vocabulary = vc;
            }
            con.Close();

            return vocabulary;
        }

        public List<Vocabulary> findVocabularyByWordList(String word, int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE wordLang1 = '" + word + "' AND userId = '" + id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader reader = cmd.ExecuteReader();

            Vocabulary vc;
            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                bool archivedAsBool = false;
                string archivedAsString = reader["archived"].ToString();
                if (archivedAsString.Equals("1"))
                {
                    archivedAsBool = true;
                }
                //bool.TryParse(archivedAsString, out archivedAsBool);

                vc = new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool);
                myVocs.Add(vc);
            }
            con.Close();

            return myVocs;
        }

        //finds all newest active vocabularies 
        public List<Vocabulary> findAllNewestActiveVocabularies(int limit, int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE archived = 0 AND userId = '" + id + "' ORDER BY dateOfCreation DESC LIMIT " + limit+ " ;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string archivedAsString = reader["archived"].ToString();
                bool archivedAsBool = false;
                bool.TryParse(archivedAsString, out archivedAsBool);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool));
            }
            con.Close();

            return myVocs;
        }

        //finds all oldest active vocabularies 
        public List<Vocabulary> findOldestActiveVocabularies(int limit, int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE archived = 0 AND userId = '" + id + "' ORDER BY dateOfCreation ASC LIMIT " + limit + " ;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string archivedAsString = reader["archived"].ToString();
                bool archivedAsBool = false;
                bool.TryParse(archivedAsString, out archivedAsBool);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool));
            }
            con.Close();

            return myVocs;
        }

        //finds random active vocabularies 
        public List<Vocabulary> findRandomActiveVocabularies(int limit, int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE archived = 0 AND userId = '" + id + "' ORDER BY RANDOM() LIMIT " + limit + " ;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string archivedAsString = reader["archived"].ToString();
                bool archivedAsBool = false;
                bool.TryParse(archivedAsString, out archivedAsBool);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool));
            }
            con.Close();

            return myVocs;
        }

        //finds active vocabularies which were long time not asked for 
        public List<Vocabulary> findLastCallASCVocabularies(int limit, int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE archived = 0 AND userId = '" + id + "' ORDER BY lastCall ASC LIMIT " + limit + " ;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                string archivedAsString = reader["archived"].ToString();
                bool archivedAsBool = false;
                bool.TryParse(archivedAsString, out archivedAsBool);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong, archivedAsBool));
            }
            con.Close();

            return myVocs;
        }

        //method to write new data (vocabulary) in db
        public bool insertVocabulary(Vocabulary vc, String date, int archived, int userId)
        {
                SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
                con.Open();
                string sql = "INSERT INTO vocabulary(wordLang1, wordLang2, memo, dateOfCreation, archived, userId) VALUES ('" + vc.getWordLang1() + "', '" + vc.getWordLang2() +
                            "', '" + vc.getMemo() + "', '" + date + "', '" + archived + "', '"+ userId+"');";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
         }
        
        //changes vocabulary details by id
        public bool updateVocabularyById(Vocabulary vc)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
                con.Open();
                string sql = "UPDATE vocabulary SET wordLang1 = '" + vc.getWordLang1() + "' , wordLang2 = '" + vc.getWordLang2() + "' , memo = '" + vc.getMemo() +
                         "' WHERE id = '" + vc.getId().ToString() + "' AND userId = '"+vc.getUserId().ToString()+"';";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            return true;
        }

        //delete vocabulary by id
        public bool deleteVocabularyById(Vocabulary vc)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "DELETE FROM vocabulary WHERE id = '" + vc.getId().ToString() + "' AND userId = '" + vc.getUserId().ToString() + "';";

            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //update vocabulary status archived
        public bool updateArchivedStatusById(Vocabulary vc, int archived)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE vocabulary SET archived = '" + archived.ToString() + "' WHERE id = '"+vc.getId().ToString()+"';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //update vocabulary last call
        public bool updateLastCallById(Vocabulary vc)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE vocabulary SET lastCall = '" + vc.getLastCall() + "' WHERE id = '" + vc.getId().ToString() + "'AND userId = '" + vc.getUserId().ToString() + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }


    }
}
