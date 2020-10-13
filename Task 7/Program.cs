using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n");
            int n = int.Parse(Console.ReadLine());
            double summ = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    summ += (1.0 / i);
                    Console.WriteLine($"result = {summ}");
                };
            }
            else Console.WriteLine("Error, n <= 0");
        }
    }
}
