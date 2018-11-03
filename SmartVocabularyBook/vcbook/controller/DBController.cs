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

namespace SmartVocabularyBook.vcbook.controller
{
   class DBController
    {
        private const String dbFile = "svb.db";

        public void initDB()
        {
            SQLiteConnection.CreateFile(dbFile);
            //createTableWords();
            doesDBExists();
            
        }

        private void doesDBExists()
        {
            String path = "svb.db";
            Console.WriteLine(File.Exists(path)? "File exists." : "File does not exits.");
        }

        private void createTableWords()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = " + dbFile+";");
            con.Open();
            string sql = "CREATE TABLE IF NOT EXISTS words(id INTEGER PRIMARY KEY AUTOINCREMENT, wordLang1 TEXT, wordLang2 TEXT, note TEXT)";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        

    }
}
