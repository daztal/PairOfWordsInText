using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOfWordsInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string absolutePath = @"C:\Users\Viachaslau\Documents\visual studio 2015\Projects\PairOfWordsInText\PairOfWordsInText\TextFile1.txt";
            string relativePath = @"TextFile1.txt";
            string text = File.ReadAllText(absolutePath);
            WordPairsCounter FinalCounter = new WordPairsCounter();
            var result = FinalCounter.SelectMostFrequentPairs(text);
			int counter = 0;
			foreach (var pair in result.Reverse())
			{
				if (counter == 20)
				{
					break;
				}
                Console.WriteLine(pair.Key + ": " + pair.Value);
				counter++;
            }
        }
    }
}