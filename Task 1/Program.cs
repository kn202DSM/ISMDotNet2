using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height;
            Console.WriteLine("Input width: ");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Input height: ");
            height = int.Parse(Console.ReadLine());

            int P = (width * 2) + (height * 2);
            Console.WriteLine($"P = {P}");

            int S = width * height;
            Console.WriteLine($"S = {S}");
        }
    }
}
