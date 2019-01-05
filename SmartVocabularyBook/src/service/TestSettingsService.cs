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
            return repository.createTableTestSettings();
        }

        public bool initialTestSetup()
        {
            TestSetup ts = new TestSetup(-1L, 1, 10, 1, true);
            insertSetUpIntoDB(ts);

            TestSetup ts2 = new TestSetup(-1L, 1, 1, 1, false);
            return true;
        }
        
        public bool updateTestSettings(TestSetup ts, int isSaved, int id)
        {
            if (repository.updateTestSettings(ts, isSaved, id))
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

        public List<TestSetup> findAll()
        {
            return repository.findAll();
        }
    }
}
