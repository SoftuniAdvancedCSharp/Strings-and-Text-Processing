using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;

            if (length == 20)
            {
                Console.WriteLine(input);
            }
            else if (length < 20)
            {
                string output = input + string.Format("{0}", new string('*', 20 - length));
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}
