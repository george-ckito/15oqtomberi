using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15oqtomberi
{
    internal class davaleba1
    {
        public void Execute()
        {
            Console.WriteLine("////////////////////////   calculator program   ////////////////////////");
            Console.WriteLine("enter first num:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose operation: (+, -, *, /)");
            string operation = Console.ReadLine();
            if(operation == "+")
            {
                Console.WriteLine("result: " + (num1 + num2));
            }
            else if (operation == "-")
            {
                Console.WriteLine("result: " + (num1 - num2));
            }
            else if (operation == "*")
            {
                Console.WriteLine("result: " + (num1 * num2));
            }
            else if (operation == "/")
            {
                if(num2 == 0)
                {
                    Console.WriteLine("division by zero is not allowed");
                    return;
                }
                Console.WriteLine("result: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("invalid operation");
            }
        }
    }
}
