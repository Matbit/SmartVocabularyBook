using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    public class LanguageModel
    {
        public int id { get; set; }
        public string languageName { get; set; }

        public LanguageModel()
        {

        }
        public LanguageModel(string languageName)
        {
            this.languageName = languageName;
        }

        public LanguageModel(int id, string languageName)
        {
            this.id = id;
            this.languageName = languageName;
        }
    }
}
