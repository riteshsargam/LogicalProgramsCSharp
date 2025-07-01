using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class ShellSort
    {
        static void Main()
        {
            int[] arr = { 54, 79, 58, 7, 42, 23, 91, 3, 74, 38, 67, 46, 18, 61, 32, 86, 14, 28 };
            int n = arr.Length;
            int gap = n / 2;
            int temp;
            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = arr[j];
                    while (j - gap >= 0 && temp < arr[j - gap])
                    {
                        arr[j] = arr[j - gap];
                        j = j - gap;
                    }
                    arr[j] = temp;
                }
                gap = gap / 2;
            }
            foreach (int i in arr)
            {
                Console.Write(i + "  ");
            }
            Console.ReadLine();
        }
    }
}
