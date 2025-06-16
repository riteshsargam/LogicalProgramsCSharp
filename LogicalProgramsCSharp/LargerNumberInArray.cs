using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class LargerNumberInArray
    {
        static void Main()
        {
            Console.Write("Specify the no of items to compare: ");
            int UB = int.Parse(Console.ReadLine());
            Console.Clear();
            int[] arr = new int[UB];
            for (int i = 0; i < UB; i++)
            {
                Console.Write($"Enter Item{i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int LargeNumber = arr[0];
            for (int i = 1; i < UB; i++)
            {
                if (arr[i] > LargeNumber)
                {
                    LargeNumber = arr[i];
                }
            }
            Console.WriteLine("Larger number in the array is: " + LargeNumber);
            Console.ReadLine();
        }
    }
}
