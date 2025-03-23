using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, k = 0; // k va determina cate numere prime sunt in interval
            do
            {
                Console.Write("Dati prima valoare : ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a <= 0);
            do
            {
                Console.Write("Dati a doua valoare : ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b <= a);
            
            Console.Write("Numerele prime : ");
            for (x = a; x <= b; x++)
                if (prim(x) == 1)
                {
                    Console.Write("{0, 3}", x);
                    k++;
                }
            Console.WriteLine();
            if (k == 0)
                Console.WriteLine("In intervalul [ {0}, {1} ] nu sunt numere prime!", a, b);
            else
                Console.WriteLine("In intervalul [ {0}, {1} ] sunt {2} numere prime!", a, b, k);
        }
        
        static int prim(int x)
        {
            if (x == 1) return 0;
            if (x % 2 == 0 && x != 2) return 0;
            for (int d = 3; d * d <= x; d += 2)
                if (x % d == 0) return 0;
            return 1;
        }
    }
}