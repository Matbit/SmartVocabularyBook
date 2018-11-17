using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.service
{
    class TestSettingsService
    {
        private static TestSettingsRepository repository = new TestSettingsRepository();

        public bool createTableTestSettings()
        {
            if (repository.createTableTestSettings())
            {
                return true;
            }
            else return false;
        }
        
        public bool updateTestSettings(TestSetup ts, int isSaved)
        {
            if (repository.updateTestSettings(ts, isSaved))
            {
                return true;
            }
            else return false;
        }
        
        public TestSetup getTestSettingsById(int id)
        {
            return repository.getTestSettingsById(id);
        }                
    }
}
