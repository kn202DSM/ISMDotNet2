using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n");
            int n = int.Parse(Console.ReadLine());
            int factorial, summ = 0;
            if (n>0) { 
            for (int j = 0; j <= n; j++)
            {
                    factorial = 1;
                    for (int i = 1; i <= j; i++)
                    {
                        factorial *= i;
                    }
                    summ += factorial;
                };
                Console.WriteLine($"result = {summ}");
            }
            else 
            {
                Console.WriteLine("Error n =< 0");
            };

            
        }
    }
}
