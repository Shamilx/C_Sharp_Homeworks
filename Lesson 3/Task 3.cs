static void Main()
{
    int[] arr = new int[20];
    Random rm = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rm.Next(-10, 30);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
    int a = Convert.ToInt32(Console.ReadLine());

    int count = 0;
    foreach(var i in arr)
    {
        if(a == i)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}