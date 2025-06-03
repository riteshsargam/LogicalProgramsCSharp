using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class PrimeNumberTest
    {
        static void Main()
        {
            Console.Write("Enter a number to check it's a prime: ");
            uint Number = uint.Parse(Console.ReadLine());
            if (Number == 0 || Number == 1)
            {
                Console.WriteLine("Please enter a number other than 0 & 1");
                return;
            }
            bool IsPrime = true;
            uint HalfNumber = Number / 2;
            for (uint i = 2; i <= HalfNumber; i++)
            {
                if (Number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime == true)
                Console.WriteLine("Given number is a prime.");
            else
                Console.WriteLine("Given number is not a prime.");
            Console.ReadLine();
        }
    }
}
