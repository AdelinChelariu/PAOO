using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Pb2
{
    class Program
    {

        static void citireMatrice(int[,] C, int n) {
            for(int i = 0; i < n; i++) {
                for(int j=0; j<n; j++) {
                    C[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void afisareMatrice(int[,] C, int n) {
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    Console.Write($"{C[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        static bool numarPrim(int a) {
            for(int i = 2; i <= a / 2; i++) {
                if(a % i == 0) {
                    return false;
                }
            }
            return true;
        }

        static bool numarPerfect(int a) {
            int s = 0;
            for(int i = 1; i <= a / 2; i++) {
                if(a % i == 0) {
                    s += i;
                }
            }
            return (s==a);
        }

        static void Main(string[] args) {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[,] C = new int[n, n];
            citireMatrice(C, n);
            afisareMatrice(C, n);
            int nrPrimDiagSec = 0, nrDiagSec = 0;
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if(i + j == n - 1) {
                        nrDiagSec++;
                        if(numarPrim(C[i, j])) {
                            nrPrimDiagSec++;
                        }
                    }
                }
            }
            Console.WriteLine($"{nrPrimDiagSec * 100 / nrDiagSec}% nr prime");

            int prodNrPerf = 1;
            for(int i = 0; i < n; i++) {
                for(int j = 1; j < n; j += 2) {
                    if(numarPerfect(C[i, j])) {
                        prodNrPerf *= C[i, j];
                    }
                }
            }
            Console.WriteLine($"{prodNrPerf}");
        }
    }
}
