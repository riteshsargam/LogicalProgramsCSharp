using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class StringToPascal
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string lower = "";
            foreach (char ch in input)
            {
                if (ch >= 65 && ch <= 90)
                    lower += (char)(ch + 32);
                else
                    lower += ch;
            }
            string pascal = "";
            bool firstChar = true, flag = false;
            foreach (char ch in lower)
            {
                if (firstChar == true)
                {
                    if (ch >= 97 && ch <= 122)
                        pascal += (char)(ch - 32);
                    firstChar = false;
                    continue;
                }
                if (flag == true)
                {
                    if (ch >= 97 && ch <= 122)
                        pascal += (char)(ch - 32);
                    flag = false;
                }
                else
                    pascal += ch;
                if (ch == 32)
                    flag = true;
            }
            Console.WriteLine(pascal);
            Console.ReadLine();
        }
    }
}
