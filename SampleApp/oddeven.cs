using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class oddeven
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are");
            for(i=1;i<=n;i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The even numbers are");
            for(i=2;i<=n;i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
