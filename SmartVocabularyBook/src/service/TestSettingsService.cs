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
            TestSetup ts = new TestSetup(-1L, 1, 10, 1, true);

            if (repository.createTableTestSettings())
            {
                insertSetUpIntoDB(ts);
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

        public bool updateSaveOption(int isSaved)
        {
            return repository.updateSaveOption(isSaved);
        }

        public int getisSavedById(int id)
        {
            return repository.getisSavedById(id);
        }

        public bool insertSetUpIntoDB(TestSetup ts)
        {
            return repository.insertSetUpIntoDB(ts);
        }
    }
}
