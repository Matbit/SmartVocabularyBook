using SmartVocabularyBook.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.service
{
    class TestService
    {
        private static TestRepository repository = new TestRepository();

        public bool createTableTest()
        {
            if (repository.createTableTest())
            {
                return true;
            }
            else return false;
        }
    }
}
