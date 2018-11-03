using System;
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
        private bool isArchived;


        public Vocabulary(String wordLang1, String wordLang2) : this(wordLang1, wordLang2, null) { }
        

        public Vocabulary(String wordLang1, String wordLang2, String memo)
        {
            this.wordLang1 = wordLang1;
            this.wordLang2 = wordLang2;
            this.memo = memo;
            this.dateOfCreation = DateTime.Today;
            this.isArchived = false;
        }
    }
}
