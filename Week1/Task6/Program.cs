using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double pi = 3.1415926;
            double a;
            double p;

            Console.WriteLine("Enter the radius of a circle");
            r = Double.Parse(Console.ReadLine());
            a = pi * (r * r);
            p = 2 * (pi * r);

            Console.WriteLine($"Perimeter = {p}");
            Console.WriteLine($"Area = {a}");
            Console.ReadLine();
        }
    }
}
