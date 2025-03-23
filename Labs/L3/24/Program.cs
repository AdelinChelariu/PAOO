using System;

namespace _24
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3;
            Console.WriteLine("Coord p1:");
            Console.Write("x: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Coord p2:");
            Console.Write("x: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Coord p3:");
            Console.Write("x: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            y3 = Convert.ToDouble(Console.ReadLine());

            double E = (x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1);
            if (E == 0)
                Console.WriteLine("Coliniare");
            else
                Console.WriteLine("Necoliniare");
        }
    }
}