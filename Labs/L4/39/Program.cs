using System;

namespace _39
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.Write("{0} ", i);
                i++;
                if (i < 10)
                    continue;
                else break;
            }
        }
    }
}