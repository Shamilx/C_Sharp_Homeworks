using System.Collections.Generic;

namespace CarRacingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // You need to pass Cars to RaceMethods.Methods.Race as List,consider this : 

            List<Racers.Base> myList = new List<Racers.Base>();

            myList.Add(new Racers.BMW("M5"));
            myList.Add(new Racers.Audi("R8"));
            myList.Add(new Racers.Toyota("Test"));

            RaceMethods.Methods.Race(myList);
        }
    }
}
