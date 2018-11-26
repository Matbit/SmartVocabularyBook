using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    class TestResultView
    {
        public long id { get; set; }
        public String dateAsString { get; set;}
        public int scores { get; set; }
        public int wrongAnswers { get; set; }
        public int grade { get; set; }
        public String memo { get; set; }


        public TestResultView()
        {

        }

        public TestResultView(int testDate, int scores, int wrongAnswers, int grade) 
        {
            
        }
                

        public String getDateAsString()
        {
            return dateAsString;
        }

        public void setDateAsString(String s)
        {
            this.dateAsString = s;
        }

        public long getId()
        {
            return id;
        }
        public void setId(long id)
        {
            this.id = id;
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
