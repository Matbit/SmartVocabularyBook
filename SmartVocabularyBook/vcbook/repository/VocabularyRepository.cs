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

        public List<Vocabulary> getAll()
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

        public List<Vocabulary> findAllBySearchTerm(String word)
        {

            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE wordLang1 LIKE '" + word + "%';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                //myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), (int)reader["id"]));

                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong));
            }
            con.Close();

            return myVocs;
        }

    }
}
