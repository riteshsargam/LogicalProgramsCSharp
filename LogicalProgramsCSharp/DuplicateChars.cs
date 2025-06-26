using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class DuplicateChars
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int Length = 0;
            foreach (char ch in input)
                Length += 1;
            char[] arr = new char[Length];
            int Index = 0;
            foreach (char ch in input)
            {
                arr[Index] = ch;
                Index += 1;
            }
            int Count1 = 0, Count2 = 0;
            foreach (char ch1 in arr)
            {
                Count1 += 1;
                foreach (char ch2 in arr)
                {
                    Count2 += 1;
                    if (Count1 != Count2)
                    {
                        if (ch1 == ch2 && ch1 != 32)
                        {
                            Console.WriteLine(ch1);
                            arr[Count1 - 1] = ' ';
                            arr[Count2 - 1] = ' ';
                            break;
                        }
                    }
                }
                Count2 = 0;
            }
            Console.ReadLine();
        }
    }
}
