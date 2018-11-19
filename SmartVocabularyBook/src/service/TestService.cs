using SmartVocabularyBook.src.model;
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

        public bool insertTest(TestResult tr)
        {
            if (repository.insertTest(tr))
            {
                return true;
            }
            else return false;
        }

        public double calcGradeInProcent(int length, int points)
        {
            return ((points * 100)/ length);
        }
    }
}
