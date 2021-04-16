using System;
using System.Collections.Generic;


namespace Rockets
{
    enum Color
    {
        BLACK,
        WHITE,
        RED,
        GREEN,
        BLUE
    }

    class Engine
    {
        private static int EngineID;
        private int ID;
        private int Power;
        private int FuelTank;

        public Engine(int power,int fuelTank) 
        {
            ID = EngineID++;
            Power = power;
            FuelTank = fuelTank;
        }

        public int getID() { return ID;  }

    }

    // Fields,constructors
    partial class Rocket
    {
        private static long ID;
        private string HangarID;
        private Color RocketsColor;
        private List<string> Passengers = new List<string>();
        private List<Engine> RocketsEngines = new List<Engine>();

        static Rocket() { ID = 0; }
        public Rocket(string HangarID)
        {
            this.HangarID = HangarID;
            ID++;
        }

        public Rocket(string HangarID, Color RocketsColor)
        {
            this.HangarID = HangarID;
            this.RocketsColor = RocketsColor;
            ID++;
        }

        public Rocket(string HangarID, Color RocketsColor, string Passenger)
        {
            this.HangarID = HangarID;
            this.RocketsColor = RocketsColor;
            this.Passengers.Add(Passenger);
            ID++;
        }

        public Rocket(string HangarID, Color RocketsColor, string Passenger, Engine engine)
            : this(HangarID, RocketsColor,Passenger)
        {
            RocketsEngines.Add(engine);
        }
    }

    // Setters,getters
    partial class Rocket
    {
        public void setHangarID(string HangarID) { this.HangarID = HangarID; }
        public void setRocketsColor(Color Color) { this.RocketsColor = Color; }

        public long getID() { return ID; }
        public string getHangarID() { return HangarID; }
        public Color getRocketsColor() { return RocketsColor; }
        public List<string> getPassengers() { return Passengers; }
        public List<Engine> getRocketsEngines() { return RocketsEngines; }
    }

    // Extra methods
    partial class Rocket
    {
        public void AddEngine(Engine engine)
        {
            if (RocketsEngines.Count < 3)
            {
                RocketsEngines.Add(engine);
            }
        }
        
        public void DeleteEngine(int ID)
        {
            foreach (var i in RocketsEngines)
            {
                if(i.getID() == ID)
                    RocketsEngines.RemoveAt(ID);
            }
        }

        public void addPassenger(string passenger)
        {
            if(Passengers.Count < 5)Passengers.Add(passenger);
        }

        public void deletePassenger(string passenger)
        {
            for (int i = 0; i < Passengers.Count;i++ )
            {
                if (Passengers[i] == passenger)
                {
                    Passengers.RemoveAt(i);
                }
            }
        }
    }

}
