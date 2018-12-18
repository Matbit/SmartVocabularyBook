using SmartVocabularyBook.src.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.repository
{
    class TestRepository
    {
        //name of sqlite file
        private const String dbFile = "svb.sqlite";


        //creates table test
        public bool createTableTest()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS tests(id INTEGER PRIMARY KEY AUTOINCREMENT, testDate TEXT NOT NULL, scores INTEGER, wrongAnswers INTEGER, userId INTEGER, grade INTEGER, memo TEXT);";
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
            string sql = "INSERT INTO tests(testDate, scores, wrongAnswers, grade, memo, userId) VALUES ('" + tr.getTestDate() +
                        "', '" + tr.getScores() + "', '" + tr.getWrongAnswers() + "', '" + tr.getGrade() + "', '" + tr.getMemo() + "', '"+tr.userId+"');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        //get all tests
        public List<TestResultView> findAllTests(int id)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM tests WHERE userId = '"+ id + "' ORDER BY testDate ASC";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<TestResultView> myTests = new List<TestResultView>();
            TestResultView trv;


            while (reader.Read())
            {
                
                string dateAsString1 = reader["testDate"].ToString();
                int date = Int32.Parse(dateAsString1);
                CultureInfo provider = CultureInfo.InvariantCulture;
                DateTime testdate = DateTime.ParseExact(dateAsString1, "yyyyMMdd", provider);
                String newDate = testdate.Day + "." + testdate.Month + "." + testdate.Year;

                
                string scoresAsString = reader["scores"].ToString();
                int scores = Int32.Parse(scoresAsString);

                string answerAsString = reader["wrongAnswers"].ToString();
                int answer = Int32.Parse(answerAsString);

                string gradeAsString = reader["grade"].ToString();
                int grade = Int32.Parse(gradeAsString);                

                trv = new TestResultView();
                trv.dateAsString = newDate;

                trv.setScores(scores);
                trv.setGrade(grade);
                trv.setWrongAnswers(answer);                
                myTests.Add(trv);
            }
            con.Close();

            return myTests;
        }

        //find last tests
        public List<TestResultView> findLastTests(int limit, int userId)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM tests WHERE userId = '"+ userId +"' ORDER BY testDate DESC LIMIT'" + limit +"' ";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<TestResultView> myTests = new List<TestResultView>();
            TestResultView trv;


            while (reader.Read())
            {

                string dateAsString1 = reader["testDate"].ToString();
                int date = Int32.Parse(dateAsString1);
                CultureInfo provider = CultureInfo.InvariantCulture;
                DateTime testdate = DateTime.ParseExact(dateAsString1, "yyyyMMdd", provider);
                String newDate = testdate.Day + "." + testdate.Month + "." + testdate.Year;


                string scoresAsString = reader["scores"].ToString();
                int scores = Int32.Parse(scoresAsString);

                string answerAsString = reader["wrongAnswers"].ToString();
                int answer = Int32.Parse(answerAsString);

                string gradeAsString = reader["grade"].ToString();
                int grade = Int32.Parse(gradeAsString);

                trv = new TestResultView();
                trv.dateAsString = newDate;

                trv.setScores(scores);
                trv.setGrade(grade);
                trv.setWrongAnswers(answer);
                myTests.Add(trv);
            }
            con.Close();

            return myTests;
        }
    }
}
