using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15oqtomberi
{
    internal class davaleba2
    {
        public void Execute()
        {
            int a, b, c;
            Console.WriteLine("///////////////////////////////   maximum number   /////////////////////////////////////");
            Console.WriteLine("enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maximum:");
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}