using SmartVocabularyBook.src.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.repository
{
    class UserRepository
    {
        private const String dbFile = "svb.db";


        //creates an user table
        public bool createTableUser()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS user(id INTEGER PRIMARY KEY AUTOINCREMENT, nickname TEXT NOT NULL, mainLanguage TEXT NOT NULL, lastTest TEXT, lastLogin TEXT, foreignLanguage TEXT, points INTEGER);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //add new user to database
        public bool insertIntoUser(User user)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "INSERT INTO user(nickname, mainLanguage, foreignLanguage, points, lastLogin, lastTest) VALUES ('" + user.nickname + "', '" + user.mainLanguage + "', '"+user.foreignLanguage+"', '"+user.points+"', '"+
                user.lastLogin+"', '"+ user.lastTest+"');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //update user setup
        public bool updateUserById(User user)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE user SET nickname = '" + user.nickname + "', mainLanguage = '" + user.mainLanguage + "', lastTest = '" + user.lastTest
                        + "', lastLogin = '" + user.lastLogin + "', foreignLanguage = '"+ user.foreignLanguage+"' WHERE id = '" + user.id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool updateUserPointsById(int id, int points)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "UPDATE user SET points = '" + points + "' WHERE id = '" + id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }


        //find all user
        public List<User> findAll()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM user;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<User> listUser = new List<User>();

            while (reader.Read())
            {
                listUser.Add(new model.User(reader["nickname"].ToString(), reader["mainLanguage"].ToString(), reader["foreignLanguage"].ToString()));
            }
            con.Close();
            return listUser;
        }

        //find user by id
        public User findUserById(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM user WHERE id = '" + id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            User first = new User();

            while (reader.Read())
            {
                User second = new User();
                second.nickname = reader["nickname"].ToString();
                second.mainLanguage = reader["mainLanguage"].ToString();
                second.foreignLanguage = reader["foreignLanguage"].ToString();

                string lastLoginAsString = reader["lastLogin"].ToString();
                int lastLogin = Int32.Parse(lastLoginAsString);

                string lastTestAsString = reader["lastTest"].ToString();
                int lastTest = Int32.Parse(lastTestAsString);

                string pointsAsString = reader["points"].ToString();
                int points = Int32.Parse(pointsAsString);
                second.points = points;
                second.lastLogin = lastLogin;
                second.lastTest = lastTest;
                first = second;
            }
            con.Close();
            return first;
        }

        public User findUserByNick(string user)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM user WHERE nickname = '" + user + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            User first = new User();
            while (reader.Read())
            {
                User second = new User();
                string idAsString = reader["id"].ToString();
                int id = Int32.Parse(idAsString);

                string lastLoginAsString = reader["lastLogin"].ToString();
                int lastLogin = Int32.Parse(lastLoginAsString);

                string pointsAsString = reader["points"].ToString();
                int points = Int32.Parse(pointsAsString);

                second.points = points;
                second.id = id;
                second.nickname = reader["nickname"].ToString();
                second.mainLanguage = reader["mainLanguage"].ToString();
                second.foreignLanguage = reader["foreignLanguage"].ToString();
                second.lastLogin = lastLogin;
                first = second;
            }
            con.Close();
            return first;

        }

        public bool deleteUserById(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "DELETE from user WHERE id = '" + id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }
    }
}
