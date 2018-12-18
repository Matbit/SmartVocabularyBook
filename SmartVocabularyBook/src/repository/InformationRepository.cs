using SmartVocabularyBook.src.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.repository
{
    class InformationRepository
    {
        //name of sqlite file
        private const String dbFile = "svb.sqlite";

        //creates table information
        public bool createTableInformation()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS information(id INTEGER PRIMARY KEY AUTOINCREMENT, userId INTEGER);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //insert information
        public bool insertInformation(Information info)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "INSERT INTO information(userId) VALUES ('" +info.userId+ "');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //update information
        public bool updateInformation(Information info)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE information SET userId = '" + info.userId + "' WHERE id = 1;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //findAllInformation (just one entry is in general allowed)
        public List<Information> getInformation()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM information;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<Information> info = new List<Information>();

            while (reader.Read())
            {
                string userIdAsString = reader["userId"].ToString();
                int userId = Int32.Parse(userIdAsString);

                Information info2 = new Information(userId);
                info.Add(info2);
            }
            con.Close();
            return info;
        }  
    }
}
