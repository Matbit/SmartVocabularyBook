using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.service
{
    class LanguageService
    {
        private static LanguageRepository repository = new LanguageRepository();

        public bool createTableLanguage()
        {
            return repository.createTableLanguage();
        }

        public bool insertIntoLanguage(string name)
        {
            if (repository.insertIntoLanguage(name))
            {
                return true;
            }
            else return false;
        }

        public bool updateLanguageById(LanguageModel lm)
        {
            return repository.updateLanguageById(lm);
        }

        public List<LanguageModel> findAll()
        {
            return repository.findAll();
        }

        public LanguageModel findLanguageById(int id)
        {
            return repository.findLanguageById(id);
        }

        public bool initialLanguage()
        {
            insertIntoLanguage(Language.DEUTSCH.ToString());
            insertIntoLanguage(Language.DÄNISCH.ToString());
            insertIntoLanguage(Language.ENGLISCH.ToString());
            insertIntoLanguage(Language.SPANISCH.ToString());
            insertIntoLanguage(Language.FRANZÖSISCH.ToString());
            insertIntoLanguage(Language.ITALIENISCH.ToString());
            insertIntoLanguage(Language.SCHWEDISCH.ToString());
            insertIntoLanguage(Language.TÜRKISCH.ToString());
            insertIntoLanguage(Language.POLNISCH.ToString());
            insertIntoLanguage(Language.PORTUGIESISCH.ToString());

            return true;
        }
    }
}
