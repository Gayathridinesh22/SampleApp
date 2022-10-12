using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, s = 0;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n > 0)
            {
                m = n % 10;
                s = s + m;
                n = n / 10;
            }
            Console.Write("Sum is " + s);
            Console.ReadLine();
        }
    }
}