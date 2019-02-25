using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Enter the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = int.Parse(Console.ReadLine());
            c = a * b;
            Console.WriteLine($"{a} + {b} = {c}");
            Console.ReadLine();
        }
    }
}
