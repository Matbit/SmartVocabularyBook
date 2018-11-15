using System;
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

        public TestVocabularyModel()
        {

        }

        public TestVocabularyModel(String word1, String word2)
        {
            this.word1 = word1;
            this.word2 = word2;
        }

        public void setWord1(String word1)
        {
            this.word1 = word1;
        }
        public String getWord1()
        {
            return word1;
        }

        public void setWord2(String word1)
        {
            this.word2 = word2;
        }
        public String getWord2()
        {
            return word2;
        }
    }
}
