using System;

namespace Lesson003_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число :");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine($"Число парне{a}");
            else
                Console.WriteLine($"Число непарне{a}");

        }
    }
}
