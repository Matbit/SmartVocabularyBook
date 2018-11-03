using SmartVocabularyBook.vcbook.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartVocabularyBook.vcbook.controller
{
    class ProgressController
    {

        private DBController dbc = new DBController();


        public void validateNewVocabulary(String word1, String word2, String memo)
        {
            word1 = word1.Trim();
            word2 = word2.Trim();
            memo = memo.Trim();

            if (string.IsNullOrEmpty(word1))
            {
                MessageBox.Show("Hauptsprache muss ausgefüllt werden", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(word2))
            {
                MessageBox.Show("Übersetzung muss ausgefüllt werden", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(memo))
            {
                memo = "";
            }

            Vocabulary vc = new Vocabulary(word1, word2, memo);

            String date = vc.getDateOfCreation().ToString();
            int archived;
            if (vc.isArchived())
                archived = 0;
            else archived = 1;

            bool ok = dbc.insertNewVocabulary(vc, date, archived);
            if (!ok)
                MessageBox.Show("Eingabe war leider nicht erfolgreich. Überprüfen Sie Ihre Angaben.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ok)
                MessageBox.Show("Neue Vokabel wurde erfolgreich hinzugefügt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
