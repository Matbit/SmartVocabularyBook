using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    class TestResult
    {
        private long id;
        private int testDate;
        private int scores;
        private int wrongAnswers;
        private int grade;
        private String memo;
        private long userId;

        public TestResult()
        {
            DateTime today = DateTime.Now;
            string dateAsString = today.Year + "" + today.Month + "" + today.Day;
            this.testDate = Int32.Parse(dateAsString);
        }

        public TestResult(long id, int testDate, int scores, int wrongAnswers, int grade)
        {
            this.id = id;

            DateTime today = DateTime.Now;
            string dateAsString = today.Year + "" + today.Month + "" + today.Day;
            this.testDate = Int32.Parse(dateAsString);

            this.scores = scores;
            this.wrongAnswers = wrongAnswers;
            this.grade = grade;
        }

        public TestResult(int testDate, int scores, int wrongAnswers, int grade)
        {
            this.id = id;

            DateTime today = DateTime.Now;
            string dateAsString = today.Year + "" + today.Month + "" + today.Day;
            this.testDate = Int32.Parse(dateAsString);

            this.scores = scores;
            this.wrongAnswers = wrongAnswers;
            this.grade = grade;
        }

        public long getId()
        {
            return id;
        }
        public void setId(long id)
        {
            this.id = id;
        }
        public int getTestDate()
        {
            return testDate;
        }
        public void setTestDate(int testDate)
        {
            this.testDate = testDate;
        }
        public int getScores()
        {
            return scores;
        }
        public void setScores(int scores)
        {
            this.scores = scores;
        }
        public int getWrongAnswers()
        {
            return wrongAnswers;
        }
        public void setWrongAnswers(int wrongAnswers)
        {
            this.wrongAnswers = wrongAnswers;
        }
        public int getGrade()
        {
            return grade;
        }
        public void setGrade(int grade)
        {
            this.grade = grade;
        }
        public String getMemo()
        {
            return memo;
        }
        public void setMemo(String memo)
        {
            this.memo = memo;
        }




    }
}
