using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FavoriteWords
{
    class Program
    {
        static void Main (string[] args)
        {
            string text = File.ReadAllText("D:\\Downloads\\test1.txt");
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
            foreach (string s in wordsCounter.Keys)
            {
                if (wordsCounter.ContainsKey(s)) wordsCounter[s]++;
                else wordsCounter.Add(s, 1);
            }


        }
    }
}





