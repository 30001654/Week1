﻿using System;
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
            int rand;
            Console.WriteLine("*********** Random Numbers **********");
            string line = "";
            
            for ( int i = 0; i < 100; i++)
            {
                for( int j = 0; j < 10; j++)
                {
                    
                    rand = rnd.Next(1000, 9999);
                    line += (rand + " ");

                }
                Console.WriteLine(line);
                line = "";
            }

            Console.ReadLine();
        }
    }
}
