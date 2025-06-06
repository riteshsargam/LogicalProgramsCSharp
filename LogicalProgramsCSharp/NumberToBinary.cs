using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class NumberToBinary
    {
        static void Main()
        {
            Console.Write("Enter an number to convert into binary: ");
            int Number = int.Parse(Console.ReadLine());
            int[] arr = new int[16];
            int i;
            for (i = 0; Number > 0; i++)
            {
                arr[i] = Number % 2;
                Number = Number / 2;
            }
            Console.Write("Binary value of the given number is: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
