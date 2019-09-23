using System;

namespace Fibonacci
{
    class Program
    {
        public static int Fibek2(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            return
                Fibek2(n - 2) + Fibek2(n - 1);
        }

        public static void Fibek1(int len)
        {
            int a = 0;
            int b = 1;
            int c;

            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fibek2(10));
            Fibek1(9);
        }
    }

}
