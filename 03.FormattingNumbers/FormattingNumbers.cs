using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int a = int.Parse(tokens[0]);
            double b = double.Parse(tokens[1]);
            double c = double.Parse(tokens[2]);

            string hex = Convert.ToString(a, 16);
            string bin = Convert.ToString(a, 2);
            Console.Write("|{0,-10}", hex.ToUpper());
            Console.Write("|{0}|", bin.PadLeft(10, '0'));
            Console.Write("{0:F2,10}|", b);
            Console.WriteLine("{0,-10:F3}|", c);
            //Console.WriteLine("|{0,-10} |{1,10}|{2,10:0.##}|{3,-10:F3}|", hex.ToUpper(), bin.PadLeft(10, '0'), b, c);

        }
    }
}
