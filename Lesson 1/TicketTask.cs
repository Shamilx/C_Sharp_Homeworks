using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main()
        {
            string ticketNumber;
            Console.WriteLine("Give ticket's number");
            ticketNumber = Console.ReadLine();
            if (ticketNumber.Length != 6)
            {
                Console.WriteLine("Input 6 digits");
                throw null;
            }

            int sum1 = 0, sum2 = 0;

            for(int i = 0;i < 6;i++)
            {
                if (i < 3) sum1 = sum1 + Convert.ToInt32(ticketNumber[i]);
                else sum2 = sum2 + Convert.ToInt32(ticketNumber[i]);
            }

            if (sum1 == sum2) Console.WriteLine("Won!");
            else Console.WriteLine("Fail!");
        }
    }
}
