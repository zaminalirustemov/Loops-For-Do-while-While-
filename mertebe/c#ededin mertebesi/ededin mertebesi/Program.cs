using System;

namespace ededin_mertebesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil ediniz: ");
            int i = int.Parse(Console.ReadLine());
            int counter = 0;
            while (i > 0)
            {
                i /= 10;
                counter++;
            }
            Console.WriteLine("Sizin edediniz " + counter + " mertebelidir.");
        }
    }
}
