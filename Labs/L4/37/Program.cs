using System;
namespace _37
{
    class Program
    {
        static void Main(string[] args)
        {
            string sir = "Acesta este un sir";
            char[] delimitator = { ' ', ',', '.', ':' };
            Console.WriteLine("Sirul care va fi impartit in cuvinte \n'{0}'", sir);
            string[] cuvant = sir.Split(delimitator);
            Console.WriteLine("Sunt {0} cuvinte in text:", cuvant.Length);
            foreach (string s in cuvant)
            {
                Console.WriteLine(s);
            }
        }
    }
}