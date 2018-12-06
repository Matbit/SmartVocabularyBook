using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    class Information
    {
        public int id { get; set; }
        public int userId { get; set; }

        public Information()
        {
        }

        public Information(int userId)
        {
            this.userId = userId;
        }





    }
}
