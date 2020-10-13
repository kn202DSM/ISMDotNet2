using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax ^ 2 + bx + c = 0");

            Console.WriteLine("Input a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input c: ");
            int c = int.Parse(Console.ReadLine());

            double D = (b * b) - 4.0 * a * c;
            Console.WriteLine($"D = {D}");
            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else
            {
                if (D == 0)
                {
                    double x = (-b) / (2 * a);
                    Console.WriteLine($"x = {x}");
                }
                else Console.WriteLine("none\n ");
            }
        }
    }
}
