using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class SumOfDigits1
    {
        static void Main()
        {
            Console.Write("Enter a number to find sum of its digits: ");
            int Number = int.Parse(Console.ReadLine());
            int Reminder, Sum = 0;
            while (Number > 0)
            {
                Reminder = Number % 10;
                Sum = Sum + Reminder;
                Number = Number / 10;
            }
            Console.WriteLine("Sum of the digits of given no is: " + Sum);
            Console.ReadLine();
        }
    }
}
