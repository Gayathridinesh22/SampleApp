using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class natural
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for(i=1;i<=10;i++)
            {
                sum = sum + 1;
            }
            Console.WriteLine("sum of first 10 natural numbers is" + sum);
            Console.ReadLine();
        }
    }

}
