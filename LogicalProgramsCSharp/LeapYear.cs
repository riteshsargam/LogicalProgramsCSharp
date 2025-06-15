using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter the year in 4 digits: ");
            int Year = int.Parse(Console.ReadLine());
            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                Console.WriteLine($"{Year} is a leap year.");
            else
                Console.WriteLine($"{Year} is not a leap year.");
            Console.ReadLine();
        }
    }
}
