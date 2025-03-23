namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            int a, b;
            Console.WriteLine("Exemplu pentru operatori aritmetici");
            Console.Write("Dati primul numar intreg   : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati al doilea numar intreg : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dati simbolul unui operator aritmetic : ");
            op = (char)Console.Read();
            switch (op)
            {
                case '+': Console.WriteLine("Adunare    : {0} + {1} = {2}", a, b, a + b);
                    break;
                case '-': Console.WriteLine("Scadere    : {0} - {1} = {2}", a, b, a - b);
                    break;
                case '*': Console.WriteLine("Inmultire  : {0} * {1} = {2}", a, b, a * b);
                    break;
                case '/': Console.WriteLine("Impartire  : {0} / {1} = {2}", a, b, (float)a / b);
                    break;
                case '%': Console.WriteLine("Modulo     : {0} % {1} = {2}", a, b, a % b);
                    break;
                default: Console.WriteLine("Simbolul nu reprezinta o operatie aritmetica");
                    break;
            }
        }
    }
}