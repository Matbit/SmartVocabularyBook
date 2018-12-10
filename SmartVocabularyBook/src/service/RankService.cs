using SmartVocabularyBook.src.model;
using SmartVocabularyBook.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.service
{
    class RankService
    {
        RankRepository repository = new RankRepository();

        public bool createTableRank()
        {
            return repository.createTableRank();
        }

        public bool insertIntoRank(string rank)
        {
            return repository.insertIntoRank(rank);
        }

        public bool updateRankById(int id, string rankTitle)
        {
            return repository.updateRankById(id, rankTitle);
        }

        public List<Rank> findAll()
        {
            return repository.findAll();
        }

        public bool initialRank()
        {
            insertIntoRank("Ahnungsloser Nullpeiler");
            insertIntoRank("Vollpfosten");
            insertIntoRank("Nixversteher");
            insertIntoRank("Anfänger");
            insertIntoRank("fortgeschrittener Anfänger");
            insertIntoRank("Guter Zuhörer");
            insertIntoRank("Versteher");
            insertIntoRank("Assistent");
            insertIntoRank("Übersetzer");
            insertIntoRank("Dolmetscher");
            return true;
        }

        public Rank findRankById(int id)
        {
            return repository.findRankById(id);
        }
    }
}
