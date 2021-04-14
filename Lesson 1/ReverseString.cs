using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] input2 = input.ToCharArray();

            Array.Reverse(input2);
            Console.WriteLine(input2);
        }
    }
}
