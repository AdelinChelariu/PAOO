using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, r, x, y;
            Console.Write("Dati primul numar : ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Dati al doilea numar : ");
            b = Convert.ToInt32(Console.ReadLine());
            
            x = a;
            y = b;
            r = x % y;
            while (r != 0)
            {
                x = y;
                y = r;
                r = x % y;
            }
            if (y != 1)
                Console.WriteLine("Cmmdc ({0}, {1}) = {2} ", a, b, y);
            else
                Console.WriteLine("{0} si {1} sunt prime intre ele ", a, b);
            Console.WriteLine("Cmmmc ({0}, {1}) = {2}", a, b, a / y * b);
            Console.ReadKey();
        }
    }
}