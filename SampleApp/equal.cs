﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class equal
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            if(a == b)
            {
                Console.WriteLine("a and b are equal");
            }
            else
            {
                Console.WriteLine("a and b are not equal");
            }
            Console.ReadLine();

            

        }
    }
}
