using System;

namespace _43
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, i, j;
            n = Convert.ToInt32(Console.ReadLine());
            int[] p, q;
            p = new int[n + 1];
            q = new int[n + 1];
            p[0] = 1;
            for (i = 1; i <= n + 1; i++)
            {
                q[0] = 1;
                q[i - 1] = 1;
                for (j = 1; j <= i - 2; j++)
                    q[j] = p[j - 1] + p[j];
                for (j = 0; j <= i - 1; j++)
                {
                    Console.Write(q[j] + " ");
                    p[j] = q[j];
                }
                Console.WriteLine();
            }
        }
    }
}