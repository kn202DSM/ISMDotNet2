using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input b");
            int b = int.Parse(Console.ReadLine());

            long summ = 1;
            for(int i = a; i <= b ; i++) {
                summ *= i;
                Console.WriteLine($"\n{summ}");
            };
        }
    }
}
