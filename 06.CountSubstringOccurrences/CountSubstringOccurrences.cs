using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string target = Console.ReadLine().ToLower();

            int count = 0;

            for (int i = 0; i <= text.Length - target.Length; i++)
            {
                string currentWord = text.Substring(i, target.Length);

                if (currentWord == target)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
