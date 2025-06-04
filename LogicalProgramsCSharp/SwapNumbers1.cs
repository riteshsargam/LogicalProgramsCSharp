using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsCSharp
{
    internal class SwapNumbers1
    {
        static void Main()
        {
            int a = 342, b = 784;
            Console.WriteLine($"Numbers Before Swap: a => {a}; b => {b}");
            a = a * b; b = a / b; a = a / b;
            Console.WriteLine($"Numbers After Swap: a => {a}; b => {b}");
            Console.ReadLine();
        }
    }
    internal class SwapNumbers2      //Solution 2
    {
        static void Main()
        {
            Console.Write("Enter 1st number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numbers Before Swap: a => {a}; b => {b}");
            a = a + b; b = a - b; a = a - b;
            Console.WriteLine($"Numbers After Swap: a => {a}; b => {b}");
            Console.ReadLine();
        }
    }

}
