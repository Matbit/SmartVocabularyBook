﻿using SmartVocabularyBook.vcbook.model;
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

        public List<Vocabulary> findAll() {
            return repository.findAll();
        }


        
        public List<Vocabulary> findAllBySearchTerm(String word, bool isMainLanguage)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return repository.findAllBySearchTerm(word, isMainLanguage); 
            }
            return new List<Vocabulary>();
        }

        public bool insertVocabulary(Vocabulary vc, String date, int archived)
        {
            if(vc != null && date != null)
            {
               return repository.insertVocabulary(vc, date, archived);
               
            }
            return false;
        }

        public Vocabulary findVocabularyByWord(String word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return repository.findVocabularyByWord(word);
            }

            return new Vocabulary();
        }
    }
}
