using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVocabularyBook.src.model
{
    class TestSetup
    {
        private long id;
        private int searchMode;
        private int count;
        private int givenLang;
        private bool isSaved;

        public TestSetup()
        {

        }

        public TestSetup(long id, int searchMode, int count, int givenLang, bool save)
        {
            this.id = id;
            this.searchMode = searchMode;
            this.count = count;
            this.givenLang = givenLang;
            this.isSaved = save;
        }

        public long getId()
        {
            return id;
        }

        public void setId(long id)
        {
            this.id = id;
        }

        public int getSearchMode()
        {
            return searchMode;
        }

        public void setSearchMode(int searchMode)
        {
            this.searchMode = searchMode;
        }

        public int getCount()
        {
            return count;
        }

        public void setCount(int count)
        {
            this.count = count;
        }

        public int getGivenLang()
        {
            return givenLang;
        }

        public void setGivenLang(int givenLang)
        {
            this.givenLang = givenLang;
        }

        public bool getSave()
        {
            return isSaved;
        }

        public void setSave(bool isSaved)
        {
            this.isSaved = isSaved;
        }
    }
}
