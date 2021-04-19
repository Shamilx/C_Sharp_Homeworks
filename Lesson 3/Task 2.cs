static void Main()
{
    Random rm = new Random();
    int[] arr = new int[10];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rm.Next(-10, 10);
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            for(int j = i; j < arr.Length;j++)
            {
                if(arr[j] < 0)
                {
                    if (j > i)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        break;
                    }
                }
            }
        }
    }

    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
}