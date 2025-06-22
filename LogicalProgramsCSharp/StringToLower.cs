using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class StringToLower
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string output = "";
            foreach (char ch in input)
            {
                if (ch >= 65 && ch <= 90)
                    output += (char)(ch + 32);
                else
                    output += ch;
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
