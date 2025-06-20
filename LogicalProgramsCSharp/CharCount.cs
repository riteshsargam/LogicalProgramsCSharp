using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class CharCount
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int Length = 0;
            foreach (char ch in input)
            {
                if (ch != 32)
                    Length += 1;
            }
            Console.WriteLine("No. of char's in given string are: " + Length);
            Console.ReadLine();
        }
    }
}
