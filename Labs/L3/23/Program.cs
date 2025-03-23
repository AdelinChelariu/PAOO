using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string rezultat;
            Console.Write("Dati prinul nr intreg: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati al doilea nr: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(a > b)
                rezultat = "primul e mai mare";
            else
                if(a<b)
                    rezultat = "primul e mai mic";
                else
                    rezultat = "nr egale";
            Console.WriteLine("dintre {0} si {1}, \"{2}\"", a, b, rezultat);
        }
    }
}
