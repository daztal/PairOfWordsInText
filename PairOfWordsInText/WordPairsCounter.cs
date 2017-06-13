using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOfWordsInText
{
    class WordPairsCounter
    {
        public Dictionary<string, int> SelectMostFrequentPairs(string text)
        {
            text = text.ToLower();
			int counter;
            string[] wordsArr = text.Split();
			Dictionary<string, int> insideDictionary = new Dictionary<string, int>();
			for (int i = 0; i < wordsArr.Length - 1; i++)
			{
				if (wordsArr[i].EndsWith(",") || wordsArr[i].EndsWith(".") || wordsArr[i].EndsWith("!") || wordsArr[i].EndsWith("?") || wordsArr[i] ==  ("") || wordsArr[i + 1] == ("") || wordsArr[i + 1].StartsWith(",") || wordsArr[i + 1].StartsWith(".") || wordsArr[i + 1].StartsWith("!") || wordsArr[i + 1].StartsWith("?"))
				{
					continue;
				}
				else
				{
					string first = wordsArr[i].Trim(new char[] { ',', '.', '!', '?', '\'', '\"' });
					string second = wordsArr[i + 1].Trim(new char[] { ',', '.', '!', '?', '\'', '\"' });
					if (insideDictionary.ContainsKey(first + " " + second))
					{
						if (insideDictionary.TryGetValue(first + " " + second, out counter))
						{
							insideDictionary[first + " " + second] = insideDictionary[first + " " + second] + 1;
						}
					}
					else
					{
						insideDictionary.Add(first + " " + second, 1);
					}
				}
			}
			var newDictionary = insideDictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
			return newDictionary;
        }
    }
}
