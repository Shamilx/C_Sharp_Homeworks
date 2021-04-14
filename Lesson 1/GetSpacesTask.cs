using System;
namespace ConsoleApplication9
{
    class Program
    {
        static void Main()
        {
            string input;
            input = Console.ReadLine();
            int spaceCount = 0;
            for (int i = 0; i < input.Length; i++)
                if (Char.IsWhiteSpace(input[i]))
                    spaceCount++;

            Console.WriteLine(spaceCount);
        }
    }
}
