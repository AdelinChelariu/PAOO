using System;

namespace Problema2 {
    class Program {
        public static void CitireMatrice(int[,] C, int n) {
            for(int i = 0; i < n; i++)
                for(int j = 0; j < n; j++)
                    C[i, j] = Convert.ToInt32(Console.ReadLine());
        }

        public static void AfisareMatrice(int[,] C, int n) {
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++)
                    Console.Write($"{C[i, j]} ");
                Console.WriteLine();
            }
        }

        public static bool EPrim(int n) {
            bool ok = false;
            if(n == 1)
                return false;
            if(n == 2)
                return true;
            if(n % 2 == 0)
                return false;
            for(int i = 2; i <= n / 2; i++) {
                if(n % i == 0)
                    return false;
            }
            return true;
        }

        public static int ProcentNrPrimeDiagSec(int[,] C, int n) {
            return 1;
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] C = new int[n, n];
            CitireMatrice(C, n);
            AfisareMatrice(C, n);
        }
    }
}
