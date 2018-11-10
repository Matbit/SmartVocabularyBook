﻿using SmartVocabularyBook.vcbook.model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.vcbook.repository
{
    class VocabularyRepository
    {

        private const String dbFile = "svb.db";

        //finds all vocabularies in database
        public List<Vocabulary> findAll()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary;";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString()));
            }
            con.Close();

            return myVocs;
        }

        //finds all vocabularies by parameter
        public List<Vocabulary> findAllBySearchTerm(String word)
        {

            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE (wordLang1 LIKE '" + word + "%') OR (wordLang2 LIKE '" + word + "%');";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader reader = cmd.ExecuteReader();

            List<Vocabulary> myVocs = new List<Vocabulary>();

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                myVocs.Add(new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong));
            }
            con.Close();

            return myVocs;
        }

        //method to write new data (vocabulary) in db
        public bool insertVocabulary(Vocabulary vc, String date, int archived)
        {
                SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
                con.Open();
                string sql = "INSERT INTO vocabulary(wordLang1, wordLang2, memo, dateOfCreation, archived) VALUES ('" + vc.getWordLang1() + "', '" + vc.getWordLang2() +
                            "', '" + vc.getMemo() + "', '" + date + "', '" + archived + "')";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
         }
        
        //method to find one vocabulary
        public Vocabulary findVocabularyByWord(String word)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile + ";");
            con.Open();
            string sql = "SELECT * FROM vocabulary WHERE wordLang1 = '" + word + "';";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            SQLiteDataReader reader = cmd.ExecuteReader();

            Vocabulary vc;
            Vocabulary vocabulary = new Vocabulary();             

            while (reader.Read())
            {
                string idAsString = reader["id"].ToString();
                long idAsLong = 0L;
                long.TryParse(idAsString, out idAsLong);

                vc = new Vocabulary(reader["wordLang1"].ToString(), reader["wordLang2"].ToString(), reader["memo"].ToString(), idAsLong);
                vocabulary = vc;
            }
            con.Close();

            return vocabulary;
        }    
       

    }
}
