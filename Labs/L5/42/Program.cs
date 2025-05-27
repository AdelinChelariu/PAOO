using System;

namespace _42
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] table = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(table.GetLength(1));
            Console.WriteLine(table.Rank);

        }
    }
}