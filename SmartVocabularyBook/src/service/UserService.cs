using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.service
{
    class UserService
    {
        private static UserRepository repository = new UserRepository();


        public bool createTableUser()
        {
            return repository.createTableUser();     
        }

        public bool insertIntoUser(User user)
        {
           return repository.insertIntoUser(user);
        }

        public bool updateUserById(User user)
        {
            return repository.updateUserById(user);
        }

        public bool initialUser()
        {
            User user = new model.User();
            user.nickname = "testdummy";
            user.mainLanguage = "Deutsch";

           return insertIntoUser(user);            
        }
    }
}
