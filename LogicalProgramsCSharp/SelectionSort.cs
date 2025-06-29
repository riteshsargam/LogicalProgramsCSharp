using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class SelectionSort
    {
        static void Main()
        {
            int[] arr = { 54, 79, 58, 7, 42, 23, 91, 3, 74, 38, 67, 46, 18, 61, 32, 86, 14, 28 };
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int lowerValue = arr[min];
                    arr[min] = arr[i]; arr[i] = lowerValue;
                }
            }
            foreach (int i in arr)
                Console.Write(i + "  ");
            Console.ReadLine();
        }
    }
}
