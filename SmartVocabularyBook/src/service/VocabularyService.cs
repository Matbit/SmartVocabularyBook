using SmartVocabularyBook.vcbook.model;
using SmartVocabularyBook.vcbook.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.vcbook.service
{
  
    class VocabularyService
    {
        private static VocabularyRepository repository = new VocabularyRepository();


        public bool createTableVocabulary()
        {
            if (repository.createTableVocabulary())
            {
                return true;
            }
            else return false;
        }
        

        public List<Vocabulary> findAll() {
            return repository.findAll();
        }


        
        public List<Vocabulary> findAllBySearchTerm(String word, bool isMainLanguage, int id)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return repository.findAllBySearchTerm(word, isMainLanguage, id); 
            }
            return new List<Vocabulary>();
        }

        public bool insertVocabulary(Vocabulary vc, String date, int archived, int userId)
        {
            if(vc != null && date != null)
            {
               return repository.insertVocabulary(vc, date, archived, userId);
               
            }
            return false;
        }

        public Vocabulary findVocabularyByWord(String word, int id)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return repository.findVocabularyByWord(word, id);
            }

            return new Vocabulary();
        }

        public List<Vocabulary> findVocabularyByWordList(String word, int id)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return repository.findVocabularyByWordList(word, id);
            }
            return new List<Vocabulary>();
        }

        public bool updateVocabularyById(Vocabulary vc)
        {
            if(vc != null)
            {
                return repository.updateVocabularyById(vc);
            }
            return false;
        }

        public bool deleteVocabularyById(Vocabulary vc)
        {
            if(vc != null)
            {
                return repository.deleteVocabularyById(vc);                
            }
            return false;
        }

        public bool deleteAllVocabulariesByUserId(int id)
        {
            return repository.deleteAllVocabulariesByUserId(id);
        }

        public bool updateArchivedStatusById(Vocabulary vc, int archived)
        {
            if(vc != null)
            {
                return repository.updateArchivedStatusById(vc, archived);
            }
            return false;
        }

        public List<Vocabulary> findAllArchived(int id)
        {
            return repository.findAllArchived(id);
        }

        public List<Vocabulary> findAllActivated(int id)
        {
            return repository.findAllActivated(id);
        }

        public List<Vocabulary> findAllNewestActiveVocabularies(int limit, int id)
        {
            return repository.findAllNewestActiveVocabularies(limit, id);
        }

        public List<Vocabulary> findOldestActiveVocabularies(int limit, int id)
        {
            return repository.findOldestActiveVocabularies(limit, id);
        }

        public List<Vocabulary> findRandomActiveVocabularies(int limit, int id)
        {
            return repository.findRandomActiveVocabularies(limit, id);
        }

        public bool updateLastCallById(Vocabulary vc)
        {
            if (repository.updateLastCallById(vc))
            {
                return true;
            }
            else return false;
        }
        
        public List<Vocabulary> findLastCallASCVocabularies(int limit, int id)
        {
            return repository.findLastCallASCVocabularies(limit, id);
        }
    }
}
