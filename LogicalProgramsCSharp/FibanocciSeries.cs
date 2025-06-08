using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class FibanocciSeries
    {
        static void Main()
        {
            Console.Write("Enter the number of elements for Fibanocci Series: ");
            int Number = int.Parse(Console.ReadLine());
            int Num1 = 0, Num2 = 1, Num3;
            Console.Write(Num1 + "  " + Num2 + "  ");
            for (int i = 2; i < Number; i++)
            {
                Num3 = Num1 + Num2;
                Console.Write(Num3 + "  ");
                Num1 = Num2;
                Num2 = Num3;
            }
            Console.ReadLine();
        }
    }
}
