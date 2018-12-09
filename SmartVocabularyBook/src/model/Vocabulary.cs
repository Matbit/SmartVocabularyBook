using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.vcbook.model
{
   public class Vocabulary
    {
        private long id;
        private String wordLang1;
        private String wordLang2;
        private String memo;
        private int dateOfCreation;
        private int lastCall;
        private bool archived;
        private int userId;
        

        public Vocabulary() : this(null, null) { }

        public Vocabulary(String wordLang1, String wordLang2) : this(wordLang1, wordLang2, null, -1, false) { }

        public Vocabulary(String wordLang1, String wordLang2, String memo) : this(wordLang1, wordLang2, memo, -1, false) { }

        public Vocabulary(String wordLang1, String wordLang2, String memo, long id, bool archived) 
        {
            this.id = id;
            this.wordLang1 = wordLang1;
            this.wordLang2 = wordLang2;
            this.memo = memo;
            this.archived = archived;

            DateTime today = DateTime.Today;
            string dayAsString = "";
            string monthAsString = "";
            if (today.Day < 10)
            {
                dayAsString = "0" + today.Day;
            }
            else
            {
                dayAsString = today.Day + "";
            }
            if (today.Month < 10)
            {
                monthAsString = "0" + today.Month;
            }
            else
            {
                monthAsString = today.Month + "";
            }
            string dateAsString = today.Year + ""+monthAsString+"" + dayAsString + "";
            this.dateOfCreation = Int32.Parse(dateAsString);
        }

        public Vocabulary(String word) : this(word, null) { }
        

        //getter and setter
        public long getId()
        {
            return id;
        }

        public void setId(long id)
        {
            this.id = id;
        }

        public String getWordLang1()
        {
            return wordLang1;
        }

        public void setWordLang1(String word)
        {
            if(!string.IsNullOrEmpty(word))
            wordLang1 = word;
        }

        public String getWordLang2()
        {
            return wordLang2;
        }

        public void setWordLang2(String word)
        {
            if (!string.IsNullOrEmpty(word))
                wordLang2 = word;
        }

        public String getMemo()
        {
            return memo;
        }

        public void setMemo(String memo)
        {
            if (!string.IsNullOrEmpty(memo))
                this.memo = memo;
        }

        public int getDateOfCreation()
        {
            return dateOfCreation;
        }

        public void setDateOfCreation(int date)
        {
            this.dateOfCreation = date;
        }

        public int getLastCall()
        {
            return lastCall;
        }

        public void setLastCall(int lastCall)
        {
            this.lastCall = lastCall;
        }

        public bool isArchived()
        {
            return archived;
        }

        public void setArchived(bool archived)
        {
            this.archived = archived;
        }
        public int getUserId()
        {
            return userId;
        }
        public void setUserId(int userId)
        {
            this.userId = userId;
        }        
    }
}
