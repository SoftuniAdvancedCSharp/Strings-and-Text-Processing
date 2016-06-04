using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.MelrahShake
{
    class MelrahShake
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int patternLength = pattern.Length;
                int strLength = str.Length;

                if (strLength < 2 * patternLength || patternLength <= 0)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(str);
                    return;
                }

                int firstIndex = str.IndexOf(pattern);
                int lastindex = str.LastIndexOf(pattern);

                StringBuilder sb = new StringBuilder();

                if (firstIndex != -1 && lastindex != -1 && lastindex >= firstIndex + patternLength)
                {

                    for (int i = 0; i < str.Length; i++)
                    {
                        if ((i < firstIndex || i >= firstIndex + patternLength) &&
                                (i < lastindex || i >= lastindex + patternLength))
                        {
                            sb.Append(str[i]);
                        }
                    }
                    str = sb.ToString();

                    int index = pattern.Length / 2;
                    StringBuilder sb1 = new StringBuilder();

                    for (int i = 0; i < patternLength; i++)
                    {
                        char letter = pattern[i];
                        if (i != index)
                        {
                            sb1.Append(letter);
                        }
                    }

                    pattern = sb1.ToString();

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(str);
                    return;
                }
            }
        }
    }
}
