using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplu5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            if(x % 2 == 0)
                Console.WriteLine("Este par");
            else
                Console.WriteLine("Este impar");
        }
    }
}
