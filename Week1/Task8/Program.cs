using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Random Numbers **********");
            int rand;
            Random rnd = new Random();

            for ( int i = 0; i < 1000; i++)
            {
                for( int j = 0; j < 7; j++)
                {
                    rand = rnd.Next(1, 5);
                    
                }
                Console.WriteLine();
            }
        }
    }
}
