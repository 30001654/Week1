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
            Random rnd = new Random();
            int[,] array = new int[10, 10];
            int rand;
            Console.WriteLine("*********** Random Numbers **********");
            string line = "";

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {

                    rand = rnd.Next(100, 999);
                    if(rand != array[i, j])
                    {
                        line += (rand + " ");
                    }

                }
                Console.WriteLine(line);
                line = "";
            }

            Console.ReadLine();
        }
    }
}
