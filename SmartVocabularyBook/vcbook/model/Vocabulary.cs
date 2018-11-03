﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.vcbook.model
{
   public class Vocabulary
    {
        private int id;
        private String wordLang1;
        private String wordLang2;
        private String memo;
        private DateTime dateOfCreation;
        private DateTime lastCall;
        private bool archived;


        public Vocabulary(String wordLang1, String wordLang2) : this(wordLang1, wordLang2, null) { }
        

        public Vocabulary(String wordLang1, String wordLang2, String memo)
        {
            this.wordLang1 = wordLang1;
            this.wordLang2 = wordLang2;
            this.memo = memo;
            this.dateOfCreation = DateTime.Today;
            this.archived = false;
        }

        //getter and setter
        public int getId()
        {
            return id;
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

        public DateTime getDateOfCreation()
        {
            return dateOfCreation;
        }

        public DateTime getLastCall()
        {
            return lastCall;
        }

        public void setLastCall(DateTime lastCall)
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
    }
}
