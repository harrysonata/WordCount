using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SharedLogic
    {
        private static string result = string.Empty;
        private static string wordcount = "Test";
        private Dictionary<string, long> allWord = new Dictionary<string, long>();


        public string countNumberofWords(string sentence, ref long count)
        {
            string[] words = null;
            result = string.Empty;
            if (sentence.Length > 0)
            {
                words = sentence.Split(' ');
                foreach (string word in words)
                { findAndcountWords(word, sentence, words); }
            }
            if (allWord != null)
                foreach (KeyValuePair<string, long> wordscount in allWord)
                { result = result + "\r\n" + wordscount.Key.ToString(); }

            count = allWord.Count;
            return result;

        }

        private void findAndcountWords(string wordtofind, string stringtoreplace, string[] wordsArray)
        {
            long counter = 1;
            string[] cloneArray;
            string stringtocounttheword = stringtoreplace;
            if (wordtofind != "")
            {
                stringtocounttheword = stringtoreplace.Replace(wordtofind, "").Trim();
                cloneArray = (stringtocounttheword != "" ? stringtocounttheword.Split(' ') : null);
                if (cloneArray != null) cloneArray = cloneArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                counter = wordsArray.Length - (cloneArray != null ? cloneArray.Length : 0);
                wordcount = wordtofind + " = " + (counter != 0 ? counter : 1);
            }
            if (!allWord.ContainsKey(wordcount)) allWord.Add(wordcount, counter);
        }

    }


}
