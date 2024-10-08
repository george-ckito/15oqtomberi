using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15oqtomberi
{
    internal class davaleba3
    {
        public void Execute()
        {
            int a, b, c;
            Console.WriteLine("//////////////////////////   triangle validator /////////////////////////");
            Console.WriteLine("enter first side:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second side:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third side:");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("not valid");
            }
        }
    }
}
