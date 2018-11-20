using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    class TestResultView : TestResult
    {
        public String dateAsString { get; set;}



        public TestResultView(int testDate, int scores, int wrongAnswers, int grade) : base()
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
    }
}
