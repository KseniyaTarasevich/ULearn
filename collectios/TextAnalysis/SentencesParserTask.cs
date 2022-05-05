using System;
using System.Linq;
using System.Collections.Generic;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            var sentencesListCopy = new List<List<string>>();

            char[] senSeparators = new char[] { ':', ';', '.', '!', '?', '(', ')' };

            string[] sentencesArray = text.ToLower().Split(senSeparators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sentence in sentencesArray)
            {
                sentencesList.Add(MakeWordList(sentence));
            }

            foreach (var list in sentencesList)
            {
                if (list != null && list.Any() && list.Count != 0)
                    sentencesListCopy.Add(list);
            }

            return sentencesListCopy;
        }

        public static List<string> MakeWordList(string sentence)
        {
            List<char> wordSeparator = new List<char>();
            List<string> wordsList = new List<string>();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (!Char.IsLetter(sentence[i]) && sentence[i] != '\'')
                {
                    wordSeparator.Add(sentence[i]);
                }
            }

            string[] words = sentence.Split(wordSeparator.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var value in words)
            {
                wordsList.Add(value.Trim());
            }

            return wordsList;
        }
    }
}