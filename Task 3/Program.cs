using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input b: ");
            int b = int.Parse(Console.ReadLine());

            double y = 2.4 * (x*x + b)/ Math.Abs((x*x + b)/a) + (a-b) * Math.Sin(a-b) + Math.Pow(10,-2) * (x - b);
            Console.WriteLine($"Result: {y}");
        }
    }
}
