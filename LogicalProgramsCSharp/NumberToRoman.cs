using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class NumberToRoman
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            int num = int.Parse(Console.ReadLine());
            string roman = ToRoman(num);
            Console.WriteLine(roman);
            Console.ReadLine();
        }
        public static string ToRoman(int num)
        {
            if (num < 0 || num > 3999)
                return "Enter a number between 1 and 3999";
            else if (num >= 1000)
                return "M" + ToRoman(num - 1000);
            else if (num >= 900)
                return "CM" + ToRoman(num - 900);
            else if (num >= 500)
                return "D" + ToRoman(num - 500);
            else if (num >= 400)
                return "CD" + ToRoman(num - 400);
            else if (num >= 100)
                return "C" + ToRoman(num - 100);
            else if (num >= 90)
                return "XC" + ToRoman(num - 90);
            else if (num >= 50)
                return "L" + ToRoman(num - 50);
            else if (num >= 40)
                return "XL" + ToRoman(num - 40);
            else if (num >= 10)
                return "X" + ToRoman(num - 10);
            else if (num >= 9)
                return "IX" + ToRoman(num - 9);
            else if (num >= 5)
                return "V" + ToRoman(num - 5);
            else if (num >= 4)
                return "IV" + ToRoman(num - 4);
            else if (num >= 1)
                return "I" + ToRoman(num - 1);
            else
                return "";
        }
    }
}
