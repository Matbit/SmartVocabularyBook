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

        public List<Vocabulary> findAll() {
            return repository.getAll();
        }


        public List<Vocabulary> findAllBySearchTerm(String word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return repository.findAllBySearchTerm(word);
            }
            return new List<Vocabulary>();
        }
    }
}
