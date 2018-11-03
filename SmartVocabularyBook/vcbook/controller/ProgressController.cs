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
                memo = null;

            }


        }
    }
}
