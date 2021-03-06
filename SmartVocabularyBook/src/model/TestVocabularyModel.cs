﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
   public class TestVocabularyModel
    {
        public String word1 { get; set; }
        public String word2 { get; set; }
        public String userWord { get; set; }
        public int score { get; set; }

        public TestVocabularyModel()
        {

        }

        public TestVocabularyModel(String word1, String word2)
        {
            this.word1 = word1;
            this.word2 = word2;
        }

        public TestVocabularyModel(String word1, String word2, String userWord)
        {
            this.word1 = word1;
            this.word2 = word2;
            this.userWord = userWord;
        }

        public void setWord1(String word1)
        {
            this.word1 = word1;
        }
        public String getWord1()
        {
            return word1;
        }

        public void setWord2(String word2)
        {
            this.word2 = word2;
        }
        public String getWord2()
        {
            return word2;
        }

        public void setUserWord(String userWord)
        {
            this.userWord = userWord;
        }

        public String getUserWord()
        {
            return userWord;
        }
        public int getScore()
        {
            return score;
        }
        public void setScore(int score)
        {
            this.score = score;
        }
    }
}
