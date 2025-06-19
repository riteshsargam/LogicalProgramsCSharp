using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class StringLength
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int Length = 0;
            foreach (char ch in input)
                Length += 1;
            Console.WriteLine("Length of given string is: " + Length);
            Console.ReadLine();
        }
    }
}
