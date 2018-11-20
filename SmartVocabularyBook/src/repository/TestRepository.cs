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
            string sql = "INSERT INTO tests(testDate, scores, wrongAnswers, grade, memo) VALUES ('" + tr.getTestDate() +
                        "', '" + tr.getScores() + "', '" + tr.getWrongAnswers() + "', '" + tr.getGrade() + "', '" + tr.getMemo() + "');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //get all tests
        public List<TestResult> findAllTests()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM tests ORDER BY testDate ASC";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<TestResult> myTests = new List<TestResult>();

            while (reader.Read())
            {

                string dateAsString = reader["testDate"].ToString();
                int date = Int32.Parse(dateAsString);

                string scoresAsString = reader["scores"].ToString();
                int scores = Int32.Parse(scoresAsString);

                string answerAsString = reader["wrongAnswers"].ToString();
                int answer = Int32.Parse(answerAsString);

                string gradeAsString = reader["grade"].ToString();
                int grade = Int32.Parse(gradeAsString);

                myTests.Add(new TestResult(date, scores , answer , grade));
            }
            con.Close();

            return myTests;
        }
    }
}
