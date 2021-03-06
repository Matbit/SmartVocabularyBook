﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    class TestResult
    {
        public long id { get; set;}
        public int testDate { get; set;}
        public int scores { get; set; }
        public int wrongAnswers { get; set;}
        public int grade { get; set;}
        public String memo { get; set;}
        public int userId { get; set;}

        public TestResult()
        {
            DateTime today = DateTime.Now;

            string dayAsString = "";
            if (today.Day < 10)
            {
                dayAsString = "0" + today.Day;
            }
            else
            {
                dayAsString = today.Day.ToString();
            }

            string monthAsString = "";

            if(today.Month < 10)
            {
                monthAsString = "0" + today.Month;
            }
            else
            {
                monthAsString = today.Month.ToString();
            }

            string dateAsString = today.Year + "" + monthAsString + "" + dayAsString;
            this.testDate = Int32.Parse(dateAsString);
        }

        public TestResult(long id, int testDate, int scores, int wrongAnswers, int grade, int userId)
        {
            this.id = id;

            DateTime today = DateTime.Now;
            string dayAsString = "";
            if(today.Day < 10)
            {
                dayAsString = "0" + today.Day;
            }
            else
            {
                dayAsString = today.Day.ToString();
            }

            string monthAsString = "";

            if (today.Month < 10)
            {
                monthAsString = "0" + today.Month;
            }
            else
            {
                monthAsString = today.Month.ToString();
            }
            string dateAsString = today.Year + "" + monthAsString + "" + dayAsString;
            this.testDate = Int32.Parse(dateAsString);
            this.scores = scores;
            this.wrongAnswers = wrongAnswers;
            this.grade = grade;
            this.userId = userId;
        }

        public TestResult(int testDate, int scores, int wrongAnswers, int grade, int userId)
        {
            this.id = id;

            DateTime today = DateTime.Now;
            string dayAsString = "";
            if (today.Day < 10)
            {
                dayAsString = "0" + today.Day;
            }
            else
            {
                dayAsString = today.Day.ToString();
            }

            string monthAsString = "";

            if (today.Month < 10)
            {
                monthAsString = "0" + today.Month;
            }
            else
            {
                monthAsString = today.Month.ToString();
            }

            string dateAsString = today.Year + "" + monthAsString + "" + dayAsString;
            this.testDate = Int32.Parse(dateAsString);

            this.scores = scores;
            this.wrongAnswers = wrongAnswers;
            this.grade = grade;
            this.userId = userId;
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
