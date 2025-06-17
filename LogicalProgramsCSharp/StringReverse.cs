using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class StringReverse
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string reverse = "";
            foreach (char ch in input)
                reverse = ch + reverse;
            Console.WriteLine($"Reverse of given string '{input}' is: '{reverse}'");
            Console.ReadLine();
        }
    }
}
