using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    class Rank
    {
        public int id { get; set; }
        public string rankTitle { get; set; }

        public Rank()
        {
        }

        public Rank(int id)
        {
            this.id = id;
        }

        public Rank(string rankTitle)
        {
            this.rankTitle = rankTitle;
        }
        public Rank(int id, string rankTitle)
        {
            this.id = id;
            this.rankTitle = rankTitle;
        }
    }
}
