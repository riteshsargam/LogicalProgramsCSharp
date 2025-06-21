using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class ReverseWords
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string word = "", reverseWords = "";
            foreach (char ch in input)
            {
                if (ch != 32)
                    word = word + ch;
                else
                {
                    reverseWords = " " + word + reverseWords;
                    word = "";
                }
            }
            if (word != "")
                reverseWords = word + reverseWords;
            Console.WriteLine(reverseWords);
            Console.ReadLine();
        }
    }
}
