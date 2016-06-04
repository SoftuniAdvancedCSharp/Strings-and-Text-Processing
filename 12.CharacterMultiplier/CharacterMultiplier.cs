using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string word1 = tokens[0];
            string word2 = tokens[1];

            if (word1.Length >= word2.Length)
            {
                MultiplyCharacters(word1, word2);
            }
            else
            {
                MultiplyCharacters(word2, word1);
            }

        }

        private static void MultiplyCharacters(string word1, string word2)
        {
            long totalSum = 0;

            for (int i = 0; i < word2.Length; i++)
            {
                totalSum += word1[i] * word2[i];
            }

            for (int i = word2.Length; i < word1.Length; i++)
            {
                totalSum += word1[i];
            }

            Console.WriteLine(totalSum);
        }
    }
}
