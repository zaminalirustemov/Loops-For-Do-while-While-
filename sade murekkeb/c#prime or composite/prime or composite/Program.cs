using System;

namespace prime_or_composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, m = 0, a = 0;
            Console.Write("Zehmet olmasa ededinizi daxil edin: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Sizin edediniz olduqca murekkebdir.");
                        a = 1;
                    break;
                }
            }
            if (a == 0)
                Console.Write("Edediniz sadedir.");
        }
    }
}
