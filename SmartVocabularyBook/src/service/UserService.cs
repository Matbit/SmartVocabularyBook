using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.repository;
using SmartVocabularyBook.vcbook.service;
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
        private static VocabularyService vocabularyRepository;


        public bool createTableUser()
        {
            return repository.createTableUser();     
        }
        public bool initialUser()
        {
            User user = new User();
            user.nickname = "NoName";
            user.mainLanguage = "Deutsch";
            user.foreignLanguage = "Englisch";
            user.lastLogin = getDateTotayAsInt();
            user.points = 1;

            return insertIntoUser(user);
        }

        public bool insertIntoUser(User user)
        {
           return repository.insertIntoUser(user);
        }

        public bool updateUserById(User user)
        {
            return repository.updateUserById(user);
        }
        public bool updateUserPointsById(int id, int points)
        {
            return repository.updateUserPointsById(id, points);
        }

        public List<User> findAll()
        {
            return repository.findAll();
        }
        public User findUserById(int id)
        {
            return repository.findUserById(id);
        }

        public User findUserByNick(string user)
        {
            return repository.findUserByNick(user);
        }

        public bool deleteUserById(int id)
        {
            vocabularyRepository = new VocabularyService();
            vocabularyRepository.deleteAllVocabulariesByUserId(id);
            repository.deleteUserById(id);
            return true;
        }
        private int getDateTotayAsInt()
        {
            int todayAsInteger = 0;
            DateTime today = DateTime.Today;
            string dayAsString = "";
            string monthAsString = "";
            if (today.Day < 10)
            {
                dayAsString = "0" + today.Day;
            }
            if (today.Month < 10)
            {
                monthAsString = "0" + today.Month;
            }
            string dateAsString = today.Year + "" + monthAsString + "" + dayAsString + "";
            todayAsInteger = Int32.Parse(dateAsString);
            return todayAsInteger;
        }



    }
}
