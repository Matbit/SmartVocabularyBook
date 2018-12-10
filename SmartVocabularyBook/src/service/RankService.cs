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
            insertIntoRank("Pfeife");
            insertIntoRank("Entdecker");
            insertIntoRank("Anfänger");
            insertIntoRank("Wissbegierig");
            insertIntoRank("fortgeschrittener Anfänger");
            insertIntoRank("Bücherwurm");
            insertIntoRank("Guter Zuhörer");
            insertIntoRank("Versteher");
            insertIntoRank("Assistent");
            insertIntoRank("Veteran");
            insertIntoRank("Übersetzer");
            insertIntoRank("Bachelor");
            insertIntoRank("Dolmetscher");
            insertIntoRank("Gelehrter");
            insertIntoRank("King");
            insertIntoRank("Master");
            insertIntoRank("Legende");


            return true;
        }

        public Rank findRankById(int id)
        {
            return repository.findRankById(id);
        }

        public Rank getRank(int points)
        {
            if (points < 2)
            {
                return repository.findRankById(1);
            }
            else if(points < 4)
            {
                return repository.findRankById(2);
            }
            else if(points < 6)
            {
                return repository.findRankById(3);
            }
            else if(points < 8)
            {
                return repository.findRankById(4);
            }
            else if(points < 12)
            {
                return repository.findRankById(5);
            }
            else if(points < 19)
            {
                return repository.findRankById(6);
            }
            else if(points < 25)
            {
                return repository.findRankById(7);
            }
            else if(points < 35)
            {
                return repository.findRankById(8);
            }
            else if(points < 50)
            {
                return repository.findRankById(9);
            }
            else if(points > 49)
            {
                return repository.findRankById(10);
            }
            return null;
        }
    }
}
