using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class Factorial
    {
        static void Main()
        {
            Console.Write("Enter a number to find it's factorial: ");
            uint Number = uint.Parse(Console.ReadLine());
            uint Result = 1;
            for (uint i = 1; i <= Number; i++)
            {
                Result = Result * i;
            }
            Console.WriteLine("Factorial of given number is: " + Result);
            Console.ReadLine();
        }
    }
}
