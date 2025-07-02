using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class QuickSort
    {
        static int[] arr;
        public static void Sort(int left, int right)
        {
            int pivot, leftEnd, rightEnd;
            leftEnd = left;
            rightEnd = right;
            pivot = arr[left];
            while (left < right)
            {
                while ((arr[right] >= pivot) && (left < right))
                {
                    right--;
                }
                if (left != right)
                {
                    arr[left] = arr[right]; left++;
                }
                while ((arr[left] <= pivot) && (left < right))
                {
                    left++;
                }
                if (left != right)
                {
                    arr[right] = arr[left];
                    right--;
                }
            }
            arr[left] = pivot;
            pivot = left;
            left = leftEnd;
            right = rightEnd;
            if (left < pivot)
            {
                Sort(left, pivot - 1);
            }
            if (right > pivot)
            {
                Sort(pivot + 1, right);
            }
        }
        static void Main()
        {
            arr = new int[] { 54, 79, 58, 7, 42, 23, 91, 3, 74, 38, 67, 46, 18, 61, 32, 86, 14 };
            Sort(0, arr.Length - 1);
            foreach (int i in arr)
            {
                Console.Write(i + "  ");
            }
            Console.ReadLine();
        }
    }
}
