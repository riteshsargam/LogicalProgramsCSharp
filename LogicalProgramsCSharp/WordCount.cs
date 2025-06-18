using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class WordCount
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int Count = 0, CharCount = 0;
            bool Flag = true, EndSpace = false;
            bool StartSpace = false;
            foreach (char ch in input)
            {
                CharCount += 1;
                if (CharCount == 1 && ch == 32)
                    StartSpace = true;
                if (ch == 32 && Flag == false)
                    continue;
                else
                {
                    Flag = true;
                    EndSpace = false;
                }
                if (Count == 0)
                    Count = 1;
                if (ch == 32)
                {
                    Count += 1;
                    Flag = false;
                    EndSpace = true;
                }
            }
            if (StartSpace == true)
                Count -= 1;
            if (EndSpace == true)
                Count -= 1;
            Console.WriteLine("No of words in the given string are: " + Count);
            Console.ReadLine();
        }
    }
}
