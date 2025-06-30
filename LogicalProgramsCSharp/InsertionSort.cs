using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class InsertionSort
    {
        static void Main()
        {
            int[] arr = { 54, 79, 58, 7, 42, 23, 91, 3, 74, 38, 67, 46, 18, 61, 32, 86, 14, 28 };
            for (int i = 0; i < arr.Length; i++)
            {
                int item = arr[i];
                int currentIndex = i;
                while (currentIndex > 0 && arr[currentIndex - 1] > item)
                {
                    arr[currentIndex] = arr[currentIndex - 1];
                    currentIndex--;
                }
                arr[currentIndex] = item;
            }
            foreach (int i in arr)
                Console.Write(i + "  ");
            Console.ReadLine();
        }
    }
}
