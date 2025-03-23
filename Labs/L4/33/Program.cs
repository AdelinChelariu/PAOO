using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, k = 0;
            do
            {
                Console.Write("Dati un numar natural : ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Eroare la citire!");
            } while (n <= 0);
            Console.Write("Numerele palindroame mai mici strict decat {0} sunt :\n", n);
            x = 1;
            
            do
            {
                if (palindrom(x) == 1)
                {
                    Console.Write(" {0,3} ", x);
                    k++;
                }
                x++;
            } while (x < n);
            Console.WriteLine();
            if (k == 0) Console.WriteLine("Nu exista numere!");
            else Console.WriteLine("Sunt {0} numere palindroame!", k);
        }
        
        static uint palindrom(int x)
        {
            int y = 0, z = x;
            do
            {
                y = y * 10 + z % 10;
                z /= 10;
            } while (z != 0);
            if (y == x) return 1;
            else return 0;
        }
    }
}