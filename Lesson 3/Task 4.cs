static void Main()
{
    int[][] arr = new int[5][];
    Random rm = new Random();

    for (int i = 0; i < arr.Length; i++)
	{
        arr[i] = new int[5];

        for (int j = 0; j < arr[i].Length; j++)
        {
            arr[i][j] = rm.Next(1, 9);
            Console.Write(arr[i][j] + " ");
        }

        Console.WriteLine();
	}

    Console.WriteLine("First number : ");
    int first = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Second number : ");
    int second = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    for (int i = 0; i < arr.Length; i++)
    {
        int temp = arr[i][first];
        arr[i][first] = arr[i][second];
        arr[i][second] = temp;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr[i].Length; j++)
        {
            Console.Write(arr[i][j] + " ");
        }
        Console.WriteLine();
    }
}