using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Input n: ");
            int n = int.Parse(Console.ReadLine());

            double z1 = ((m-1) * Math.Sqrt(m) - (n-1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3)*n) + n*m + m*m - m);
            Console.WriteLine($"z1 = {z1}");

            double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"z2 = {z2}");
        }
    }
}
