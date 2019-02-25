using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number to view its multiplication table.");
            a = int.Parse(Console.ReadLine());

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{a} x {i} = {a*i}");
            }
            Console.ReadLine();
        }
    }
}
