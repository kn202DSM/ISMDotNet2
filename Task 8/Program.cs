using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input a");
            double a = int.Parse(Console.ReadLine());

            double summ = 1;
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    summ *= a;
                    Console.WriteLine($"result = {summ}");
                };
            }
            else Console.WriteLine("Error, n <= 0");
        }
    }
}
