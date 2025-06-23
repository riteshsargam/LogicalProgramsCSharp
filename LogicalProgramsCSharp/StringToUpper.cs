using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class StringToUpper
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string output = "";
            foreach (char ch in input)
            {
                if (ch >= 97 && ch <= 122)
                    output += (char)(ch - 32);
                else
                    output += ch;
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
