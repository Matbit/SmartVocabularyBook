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
            string sql = "CREATE TABLE IF NOT EXISTS user(id INTEGER PRIMARY KEY AUTOINCREMENT, nickname TEXT NOT NULL, mainLanguage TEXT NOT NULL, lastTest TEXT, lastLogin TEXT);";
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
            string sql = "INSERT INTO user(nickname, mainLanguage) VALUES ('" + user.nickname + "', '" + user.mainLanguage + "');";
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
            string sql = "UPDATE user SET nickname = '" + user.nickname + "' mainLanguage = '" + user.mainLanguage + "' lastTest = '" + user.lastTest
                        + "' lastLogin = '" + user.lastLogin + "' WHERE id = '" + user.id + "';";
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
                listUser.Add(new model.User(reader["nickname"].ToString(), reader["mainLanguage"].ToString()));
            }
            con.Close();
            return listUser;
        }

        //find user by id
        public User findUserById(User user)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM user WHERE id = '" + user.id + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            User first = new User();

            while (reader.Read())
            {
                User second = new User(reader["nickname"].ToString(), reader["mainLanguage"].ToString());
                first = second;
            }
            con.Close();
            return first;
        }
    }
}
