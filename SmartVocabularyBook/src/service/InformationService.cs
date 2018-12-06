using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.service
{
    class InformationService
    {
        private static InformationRepository repository = new InformationRepository();

        public bool createTableInformation()
        {
            return repository.createTableInformation();
        }

        public bool initialInformation()
        {
            Information info = new Information(1);
            return insertInformation(info);
        }



        public bool insertInformation(Information info)
        {
            return repository.insertInformation(info);
        }

        public bool updateInformation(Information info)
        {
            return repository.updateInformation(info);
        }

        public List<Information> getInformation()
        {
            return repository.getInformation();
        }
    }
}
