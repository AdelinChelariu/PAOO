namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            double rc, ic;
            double x, y, z;
            int n;
            for (ic = 1.4; ic >= -1.4; ic -= 0.05)
            {
                for (rc = -0.7; rc <= 1.80; rc += 0.05)
                {
                    n = 0;
                    x = ic * ic + rc * rc;
                    y = 2 * ic - 4 * rc;
                    z = x * x + y * y;
                    while (n <= 40 && z < 5)
                    {
                        x = ic * ic + rc * rc - rc;
                        y = 2 * ic - 4 * rc;
                        z = x * x - y * y;
                        n++;
                    }
                    switch (n % 4)
                    {
                        case 0: Console.Write("*"); break;
                        case 1: Console.Write("$"); break;
                        case 2: Console.Write("o"); break;
                        case 3: Console.Write("@"); break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}