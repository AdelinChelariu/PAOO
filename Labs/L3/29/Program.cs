using System;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = 1223466, b;
            b = CateCifrePare(a);
            Console.WriteLine("Numarul {0} are {1} cifre pare", a, b);
        }

        static uint CateCifrePare(uint a)
        {
            uint k = 0;
            if (a == 0) k = 1;
            while (a != 0)
            {
                if (a % 10 % 2 == 0) 
                    k++;
                a = a / 10;
            }
            return k;
        }
    }
}
