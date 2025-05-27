using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pb1
{
    class Program
    {

        static int cifraControl(int a) {

            int s = 0;
            while(a != 0) {
                s += a % 10;
                a /= 10;
            }

            return (s<10)?(s):(cifraControl(s));
        }

        static void Main(string[] args)
        {
            int x, y, count = 0;
            x = Convert.ToInt32(Console.ReadLine());
            y = x;
            
            StreamWriter path = new StreamWriter("../../rezultatPb1.txt");
            while(x != 0) {
                y = x;
                x = Convert.ToInt32(Console.ReadLine());

                int a = x, b = y, r;
                while(a * b != 0) {
                    if(a<b) {
                        int aux = a;
                        a = b;
                        b = aux;
                    }
                    r = a % b;
                    a = b;
                    b = r;
                    if(a == 1) {
                        Console.WriteLine($"{x}, {y} prime intre ele");
                        path.WriteLine($"{a}, {b} prime intre ele");
                        count++;
                    }
                }
            }
            Console.WriteLine($"{count} perechi.");
            path.WriteLine($"{count} perechi.");
            Console.WriteLine($"{cifraControl(y)}");
            path.WriteLine($"{cifraControl(y)}");
        }
    }
}
