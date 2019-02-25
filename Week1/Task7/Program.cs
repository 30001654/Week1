using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Enter the first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swap: A = {a}  B = {b}");

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"After swap: A = {a}  B = {b}");
            Console.ReadLine();
        }
    }
}
