using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        public static bool Prime(int a, int b) {
            while(b != 0) {
                int aux = b;
                b = a % b;
                a = aux;
            }
            return a == 1;
        }

        public static int CifraControl(int x) {
            int s = 0;
            while(x > 0) {
                s += x % 10;
                x = x / 10;
            }
            return (s > 9) ? CifraControl(s) : s;
        }

        static void Main(string[] args)
        {
            int x, y, count = 0;
            string s = "";
            x = Convert.ToInt32(Console.ReadLine());
            y = x;
            while(x != 0) {
                y = x;
                x = Convert.ToInt32(Console.ReadLine());
                if(Prime(x, y)) {
                    Console.WriteLine("{1} si {0} sunt prime intre ele", x, y);
                    s += $"{y} si {x} sunt prime intre ele. \n";
                    count++;
                }
            }
            Console.WriteLine("Ai introdus un numar de {0} perechi de nr prime intre ele.", count);
            s += $"Ai introdus un numar de {count} perechi de nr prime intre ele. \n";
            Console.WriteLine("Cifra de control al lui {0} este {1}.",y, CifraControl(y));
            s += $"Cifra de control al lui {y} este {CifraControl(y)}. \n";

            string path = "..\\..\\out.txt";

            using(StreamWriter outputFile = new StreamWriter(path)) {
                    outputFile.WriteLine(s);
            }

        }
    }
}
