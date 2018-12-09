using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;
using SmartVocabularyBook.vcbook.model;
using SmartVocabularyBook.vcbook.service;
using SmartVocabularyBook.src.service;

namespace SmartVocabularyBook.vcbook.controller
{
   class DBController
    {
        //name of sqlite file
        private const String dbFile = "svb.db";

        //static member
        static VocabularyService serviceVocabulary = new VocabularyService();
        static UserService serviceUser = new UserService();
        static TestSettingsService serviceTestSettings = new TestSettingsService();
        static TestService serviceTest = new TestService();
        static LanguageService serviceLanguage = new LanguageService();
        static InformationService serviceInformation = new InformationService();

        //method is called by the constructor of "main" class
        public void initDB()
        {
            if (!doesDBExists())
                SQLiteConnection.CreateFile(dbFile);

            try
            {
                //create all tables
                serviceVocabulary.createTableVocabulary();
                serviceTest.createTableTest();
                serviceTestSettings.createTableTestSettings();
                serviceUser.createTableUser();
                serviceLanguage.createTableLanguage();
                serviceInformation.createTableInformation();

                //initial entries
                initialTestSetup();
                initialUser();
                initialLanguage();
                initialInformation();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                        
        }

        //initial user
        private void initialUser()
        {
            if (serviceUser.findAll().Count < 1)
            {
                serviceUser.initialUser();
            }
        }

        //initial testsetup
        private void initialTestSetup()
        {
            if(serviceTestSettings.findAll().Count < 1)
            {
                serviceTestSettings.initialTestSetup();
            }
        }

        //initial language
        private void initialLanguage()
        {
            if(serviceLanguage.findAll().Count < 1)
            {
                serviceLanguage.initialLanguage();
            }
        }

        private void initialInformation()
        {
            if(serviceInformation.getInformation().Count < 1)
            {
                serviceInformation.initialInformation();
            }
        }

        //returns a boolean whether a file exists
        private bool doesDBExists()
        {
           return File.Exists(dbFile);
        }

       
    }
}
