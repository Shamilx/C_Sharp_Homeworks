using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main()
        {
            int x = 0, y = 0;

            Console.WriteLine("First Number : ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (; x < y; x++)
                Console.WriteLine(x);
        }
    }
}