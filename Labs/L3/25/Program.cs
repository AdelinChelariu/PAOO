
namespace _25
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, x;
            Console.WriteLine("Capetele intervalului: ");
            Console.Write("stanga:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("dreapta:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                x = a;
                a = b;
                b = x;
            }

            Console.Write("x= ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x >= a && x <= b)
                Console.WriteLine("Numarul {2} in intervalul [{0}, {1}].", a, b, x);
            else
                Console.WriteLine("Numarul {2} inafara intervalului [{0}, {1}].", a, b, x);
        }
    }
}