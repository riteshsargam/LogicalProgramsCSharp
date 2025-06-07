using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class PalindromeNumber
    {
        static void Main()
        {
            Console.Write("Enter a Number: ");
            int Number = int.Parse(Console.ReadLine());
            int OldNumber = Number;
            int Reminder, Reverse = 0;
            while (Number != 0)
            {
                Reminder = Number % 10;
                Reverse = (Reverse * 10) + Reminder;
                Number = Number / 10;
            }
            if (OldNumber == Reverse)
                Console.WriteLine("Given number is a palindrome");
            else
                Console.WriteLine("Given number is not a palindrome");
            Console.ReadLine();
        }
    }
}
