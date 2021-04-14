using System;

namespace ConsoleApplication9
{
    class Program
    {
        static string getInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        static void Main()
        {
            // Getting input as char array
            string getString = getInput();
            char[] input = new char[getString.Length];
            input = getString.ToCharArray();

            for (int i = 0; i < getString.Length; i++)
            {
                if (Char.IsUpper(input[i]))
                    input[i] = Char.ToLower(input[i]);
                else
                    input[i] = Char.ToUpper(input[i]);
            }

            Console.Write(input);
        }
    }
}
