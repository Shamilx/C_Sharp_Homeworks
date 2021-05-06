using System;
using System.Collections.Generic;
using Racers;

namespace RaceMethods
{
    static class Methods
    {
        public delegate bool MyDelegate();

        public static void Race(List<Base> Racers)
        {
            if (Racers.Count <= 1)
            {
                CantRace(); // When User sends one car to race,program throws an exception.
            }

            MyDelegate RacersList = FillRacerList(Racers);

            StartRace(RacersList);
            DisplayPassedDistances(Racers);
        }

        private static void DisplayPassedDistances(List<Base> Racers)
        {
            foreach (var item in Racers)
            {
                System.Console.WriteLine("Racers.Model : " + item.GetModel() +
                "   Racers.PassedDistance : " + item.GetPassedDistnace());
            }
        }

        private static void StartRace(MyDelegate Racers)
        {
            bool myBoolean = false;

            while (myBoolean == false)
            {
                foreach (MyDelegate i in Racers.GetInvocationList())
                {
                    myBoolean = i();

                    if (myBoolean == true)
                    {
                        return;
                    }
                }
            }
        }


        private static MyDelegate FillRacerList(List<Base> Racers)
        {
            MyDelegate RacingCars = new MyDelegate(Racers[0].Race);

            for (int i = 1; i < Racers.Count; i++)
            {
                RacingCars += Racers[i].Race;
            }

            return RacingCars;
        }


        private static void CantRace()
        {
            throw new UserDefExcs.CantRaceOnecar("You cant race one car.");
        }
    }
}