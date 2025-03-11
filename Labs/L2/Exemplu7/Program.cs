using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplu7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 5;
            a = c++;
            b = ++c;
            Console.WriteLine("a = {0} b = {1}", a, b);
        }
    }
}
