using System;
using System.IO;

namespace _40
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                File.OpenRead("Gigel.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Nu avem");
            }
            finally
            {
                Console.WriteLine("Acest bloc se va executa");
            }
        }
    }
}