using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class ArmstrongNumber
    {
        static void Main()
        {
            Console.Write("Enter a number to find it is Armstrong: ");
            int Number = int.Parse(Console.ReadLine());
            int Original = Number;
            int Reminder, Sum = 0;
            while (Number > 0)
            {
                Reminder = Number % 10;
                Sum = Sum + (Reminder * Reminder * Reminder);
                Number = Number / 10;
            }
            if (Original == Sum)
                Console.Write($"{Original} is an armstrong number");
            else
                Console.Write($"{Original} is not an armstrong number");
            Console.ReadLine();
        }
    }
}
