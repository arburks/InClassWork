using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._20._20_InClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = { 'a', 'b', 'c' };
            char[] charArray2 = new char[3];
            //^^three slots in this char slot: 0,1,2

            int[] intArray = { 1, 2, 3 };
            int[] intArray2 = new int[4];
            intArray2[0] = 1;
            intArray2[1] = 2;
            intArray2[2] = 1;
            intArray2[3] = 4;

            string sentence = "The quick brown fox jumps over the lazy dog.";

            char sentenceChar = sentence[2];

            //foreach(char letter in sentence)
            //{
            //    Console.WriteLine($"{letter}");
            //}

            //string sentenceLength = sentence.PadLeft(10);
            int sentenceLength = sentence.Length;
            string truncateSentence = sentence.Substring(0, 19);
            string lowerCaseSentence = sentence.ToLower();
            string upperCaseSentence = sentence.ToUpper();
            string trimmedSentence = sentence.Trim();

            char[] trimChars = { 'x', 'y', 'z' };
            string trimmedCharSentence = sentence.Trim(trimChars);
            bool removeBadChars = sentence.Contains("fox");
            string[] splitSentence = trimmedSentence.Split('-');

            Console.WriteLine(splitSentence[0]);

            Console.WriteLine(truncateSentence);

            Console.ReadKey();

        }
    }
}
