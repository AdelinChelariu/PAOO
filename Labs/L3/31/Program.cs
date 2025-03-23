using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n, min, v;
            Console.Write("Dati un numar intreg pozitiv : ");
            n = Convert.ToUInt32(Console.ReadLine());
            min = MinCifra(n);
            v = Valoare(n, min);
            Console.WriteLine("Eliminand cifra minima {0} din {1} obtinem {2}", min, n, v);
        }

        static uint MinCifra(uint x)
        {
            uint min = 9;
            while (x != 0)
            {
                if (x % 10 < min) min = x % 10;
                x /= 10;
            }
            return min;
        }

        static uint Valoare(uint x, uint min)
        {
            uint y = 0, p = 1;
            while (x != 0)
            {
                if (x % 10 != min)
                {
                    y = y + (x % 10) * p;
                    p *= 10;
                }
                x /= 10;
            }
            return y;
        }
    }
}