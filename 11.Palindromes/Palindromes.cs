using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ';', '!', '.', ' ', '?' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (string word in input)
            {
                int startIndex = 0;
                int lastIndex = word.Length - 1;
                int iterations = word.Length / 2;
                bool hasMatch = false;

                for (int i = 0; i <= iterations; i++)
                {
                    if (word[startIndex] == word[lastIndex])
                    {
                        startIndex++;
                        lastIndex--;
                        hasMatch = true;
                        continue;
                    }
                    else
                    {
                        hasMatch = false;
                        break;
                    }
                }

                if (hasMatch)
                {
                    palindromes.Add(word);
                }
            }

            Console.Write("[");
            Console.Write(string.Join(", ", palindromes));
            Console.WriteLine("]");
        }
    }
}
