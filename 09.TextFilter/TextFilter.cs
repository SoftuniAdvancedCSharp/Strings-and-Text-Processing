using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            StringBuilder output = new StringBuilder(text);

            for (int i = 0; i < tokens.Length; i++)
            {
                string bannedWord = tokens[i];
                int length = bannedWord.Length;

                Regex regex = new Regex(bannedWord);
                Match match = regex.Match(text);

                while (match.Success)
                {
                    int index = match.Index;
                    output.Remove(index, length);
                    output.Insert(index, new string('*', length));

                    match = match.NextMatch();
                }
            }
            
            Console.WriteLine(output);
        }
    }
}
