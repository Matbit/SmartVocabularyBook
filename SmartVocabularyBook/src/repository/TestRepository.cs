using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.repository
{
    class TestRepository
    {
        //name of sqlite file
        private const String dbFile = "svb.db";


        //creates table test
        public bool createTableTest()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS test(id INTEGER PRIMARY KEY AUTOINCREMENT, testDate TEXT NOT NULL, testTime TEXT, score INTEGER NOT NULL, memo TEXT);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
