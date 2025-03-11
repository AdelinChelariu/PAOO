using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplu6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool v1, v2;
            v1 = true;
            v2 = true;
            Console.WriteLine("{0,6}" + " & " + "{1,6}" + " = " + "{2,6}", v1, v2, v1 & v2);

            v1 = true;
            v2 = false;
            Console.WriteLine("{0,6}" + " & " + "{1,6}" + " = " + "{2,6}", v1, v2, v1 & v2);

            v1 = false;
            v2 = true;
            Console.WriteLine("{0,6}" + " & " + "{1,6}" + " = " + "{2,6}", v1, v2, v1 & v2);

            v1 = false;
            v2 = false;
            Console.WriteLine("{0,6}" + " & " + "{1,6}" + " = " + "{2,6}", v1, v2, v1 & v2);

            Console.ReadKey();
        }
    }
}
