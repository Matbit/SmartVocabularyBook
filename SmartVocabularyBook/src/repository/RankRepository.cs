using SmartVocabularyBook.src.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.repository
{
    class RankRepository
    {
        private const String dbFile = "svb.sqlite";

        //create Rank
        public bool createTableRank()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS rank(id INTEGER PRIMARY KEY AUTOINCREMENT,rankTitle TEXT NOT NULL);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //insert into rank
        public bool insertIntoRank(string rank)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "INSERT INTO rank(rankTitle) VALUES ('" + rank + "');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //update rank
        public bool updateRankById(int id, string rankTitle)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE rank SET rankTitle ='" + rankTitle + "' WHERE id = '" + id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //find all entries
        public List<Rank> findAll()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM rank;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Rank> listRank = new List<Rank>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                int id = Int32.Parse(idAsString);

                listRank.Add(new Rank(id, reader["rankTitle"].ToString()));
            }
            con.Close();
            return listRank;
        }

        //find entry by id
        public Rank findRankById(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM rank WHERE id = '" + id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            Rank rank = new Rank();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                int idRank = Int32.Parse(idAsString);

                rank = new model.Rank(idRank, reader["rankTitle"].ToString());
            }
            con.Close();
            return rank;
        }
    }
}
