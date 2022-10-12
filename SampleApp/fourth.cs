using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class fourth
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            c = Convert.ToInt32(Console.ReadLine());
            if(a >= b && a >= c)
            {
                Console.WriteLine("The largest number is " + a);
            }
            if(b >= a && b >= c)
            {
                Console.WriteLine("The largest number is " + b);
            }
            if(c >= a && c >= b)
            {
                Console.WriteLine("The largest number is " + c);
            }
            Console.ReadLine();
        }
    }
}


