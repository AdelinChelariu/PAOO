using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplu4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string rezultat;
            a = int.Parse(Console.ReadLine());
            Console.Write("Numarul " + a);
            rezultat = (a > 0) ? " este pozitiv." : " este negativ.";
            Console.Write(rezultat);
            Console.WriteLine();
        }
    }
}
