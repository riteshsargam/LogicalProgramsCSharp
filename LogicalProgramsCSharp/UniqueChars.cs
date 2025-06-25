using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class UniqueChars
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            bool Exists = false;
            int Count1 = 0, Count2 = 0;
            foreach (char ch1 in input)
            {
                Count1 += 1;
                foreach (char ch2 in input)
                {
                    Count2 += 1;
                    if (Count1 != Count2)
                    {
                        if (ch1 != ch2 && ch1 != 32)
                            Exists = false;
                        else
                        {
                            Exists = true;
                            break;
                        }
                    }
                }
                if (Exists == false)
                    Console.Write(ch1);
                Count2 = 0; Exists = false;
            }
            Console.ReadLine();
        }
    }
}
