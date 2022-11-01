using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.Write("Eded daxil edin: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write(number + " != " + fact);
        }
    }
}
