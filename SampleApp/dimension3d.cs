using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class dimension3d
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[2, 2, 3]
            {

                { {3,2,7},{2,4,5} },
                {{2,4,8},{4,4,8} }
            };
            Console.WriteLine(array[0, 0, 0]);//2
            Console.WriteLine(array[0, 1, 0]);//4
            Console.ReadLine();
        }
    }
}
