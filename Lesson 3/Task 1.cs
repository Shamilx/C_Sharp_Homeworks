using System;

namespace ConsoleApplication25
{
    class Program
    {
        static void Main()
        {
            Random rm = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rm.Next(0, 3);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    for(int j = i;j < arr.Length;j++)
                    {
                        if(arr[j] != 0)
                        {
                            arr[i] = arr[j];
                            arr[j] = 0;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) arr[i] = -1;

                Console.Write(arr[i] + " ");
            }
        }
    }
}
