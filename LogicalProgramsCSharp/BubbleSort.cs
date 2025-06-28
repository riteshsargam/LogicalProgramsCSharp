using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 54, 79, 58, 7, 42, 23, 91, 3, 74, 38, 67, 46, 18, 61, 32, 86, 14, 28 };
            bool itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int lowerValue = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);

            foreach (int i in arr)
                Console.Write(i + "  ");
            Console.ReadLine();
        }
    }
}
