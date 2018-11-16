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
        private String searchMode;
        private int count;
        private String givenLang;
        private bool isSaved;

        public TestSetup()
        {

        }

        public TestSetup(long id, String searchMode, int count, String givenLang, bool save)
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

        public String getSearchMode()
        {
            return searchMode;
        }

        public void setSearchMode(String searchMode)
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

        public String getGivenLang()
        {
            return givenLang;
        }

        public void setGivenLang(String givenLang)
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
