using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    public class User
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public string mainLanguage { get; set; }
        public int lastTest { get; set; }
        public int lastLogin { get; set; }
        public int foreignLanguageId { get; set; }

        public User()
        {

        }

        public User(int id)
        {
            this.id = id;
        }

        public User(string nickname, string mainLanguage)
        {
            this.nickname = nickname;
            this.mainLanguage = mainLanguage;
        }
    }
}
