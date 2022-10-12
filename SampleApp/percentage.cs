using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class percentage
    {
        static void Main(string[] args)
        {
            int rollno, m, p, c, total;
            double percentage;
            String n;
            Console.WriteLine("Enter the name");
            n = Console.ReadLine();
            Console.WriteLine("Enter the Rollno");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of maths");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of physics");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mark of chemistry");
            c = Convert.ToInt32(Console.ReadLine());
            total = m + p + c;
            percentage = total / 3.0;
            Console.WriteLine(n + "roll no is" + rollno + " and the total percentage is" + percentage);
            Console.ReadLine();


        }
    }
}
