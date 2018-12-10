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
            insertIntoRank("Ahnungsloser Nullpeiler");  //1
            insertIntoRank("Vollpfosten");              //2
            insertIntoRank("Nixversteher");             //3
            insertIntoRank("Pfeife");                   //4
            insertIntoRank("Entdecker");                //5    
            insertIntoRank("Anfänger");                 //6
            insertIntoRank("Wissbegierig");             //7
            insertIntoRank("fortgeschrittener Anfänger");//8
            insertIntoRank("Bücherwurm");               //9
            insertIntoRank("Guter Zuhörer");            //10    
            insertIntoRank("Könner");                   //11
            insertIntoRank("Assistent");                //12
            insertIntoRank("Veteran");                  //13
            insertIntoRank("Übersetzer");               //14    
            insertIntoRank("Bachelor");                 //15
            insertIntoRank("Dolmetscher");              //16
            insertIntoRank("Gelehrter");                //17
            insertIntoRank("King");                     //18
            insertIntoRank("Master");                   //19
            insertIntoRank("Legende");                  //20


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
            else if(points < 10)
            {
                return repository.findRankById(5);
            }
            else if(points < 14)
            {
                return repository.findRankById(6);
            }
            else if(points < 20)
            {
                return repository.findRankById(7);
            }
            else if(points < 30)
            {
                return repository.findRankById(8);
            }
            else if(points < 42)
            {
                return repository.findRankById(9);
            }
            else if(points < 56)
            {
                return repository.findRankById(10);
            }

            else if(points < 70)
            {
                return repository.findRankById(11);
            }
            else if(points < 110)
            {
                return repository.findRankById(12);
            }
            else if(points < 180)
            {
                return repository.findRankById(13);
            }
            else if(points < 240)
            {
                return repository.findRankById(14);
            }
            else if(points < 300)
            {
                return repository.findRankById(15);
            }
            else if(points < 360)
            {
                return repository.findRankById(16);
            }
            else if(points < 480)
            {
                return repository.findRankById(17);
            }
            else if(points < 600)
            {
                return repository.findRankById(18);
            }
            else if(points < 730)
            {
                return repository.findRankById(19);
            }
            else if (points > 899)
            {
                return repository.findRankById(20);
            }
            return null;
        }
    }
}
