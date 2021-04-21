using System;
using Cities;

namespace AnotherProject
{
    class Program
    {
        static void Main(string[] args)
        {
            City Italy = new City("Italy",5000);
            City Baku = new City("Baku", 5000);
            Console.WriteLine(Italy.compareTo(Italy));
        }
    }
}
