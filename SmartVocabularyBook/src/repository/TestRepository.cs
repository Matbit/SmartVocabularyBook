using SmartVocabularyBook.src.model;
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
            string sql = "CREATE TABLE IF NOT EXISTS tests(id INTEGER PRIMARY KEY AUTOINCREMENT, testDate TEXT NOT NULL, scores INTEGER, wrongAnswers INTEGER," +
                "grade INTEGER, memo TEXT);";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //insert a new test
        public bool insertTest(TestResult tr)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "INSERT INTO tests(id, testDate, scores, wrongAnswers, grade, memo) VALUES ('" + tr.getId() + "', '" + tr.getTestDate() +
                        "', '" + tr.getScores() + "', '" + tr.getWrongAnswers() + "', '" + tr.getGrade() + "', '" + tr.getMemo() + "');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
    }
}
