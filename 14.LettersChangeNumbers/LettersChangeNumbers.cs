using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            decimal result = 0;
            decimal finalSum = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                string currentString = tokens[i];
                char firstLetter = currentString[0];
                char lastLetter = currentString[currentString.Length - 1];
                string numberAsString = currentString.Substring(1, currentString.Length - 2);
                decimal number = decimal.Parse(numberAsString);

                if (firstLetter >= 'a' && firstLetter <= 'z')
                {
                    result = number * (int)(firstLetter - 'a' + 1);
                }
                else
                {
                    result = number / (int)(firstLetter - 'A' + 1);
                }

                if (lastLetter >= 'a' && lastLetter <= 'z')
                {
                    result = result + (int)(lastLetter - 'a' + 1);
                }
                else
                {
                    result = result - (int)(lastLetter - 'A' + 1);
                }

                finalSum += result;

            }

            Console.WriteLine("{0:F2}", finalSum);
        }
    }
}
