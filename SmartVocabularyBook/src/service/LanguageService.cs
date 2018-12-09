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
            insertIntoLanguage(Language.Deutsch.ToString());
            insertIntoLanguage(Language.Dänisch.ToString());
            insertIntoLanguage(Language.Englisch.ToString());
            insertIntoLanguage(Language.Spanisch.ToString());
            insertIntoLanguage(Language.Französisch.ToString());
            insertIntoLanguage(Language.Italienisch.ToString());
            insertIntoLanguage(Language.Schwedisch.ToString());
            insertIntoLanguage(Language.Türkisch.ToString());
            insertIntoLanguage(Language.Polnisch.ToString());
            insertIntoLanguage(Language.Portugiesisch.ToString());

            return true;
        }
    }
}
