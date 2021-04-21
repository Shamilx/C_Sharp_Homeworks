
namespace Cities
{
    class City
    {
        string Name;
        int Population;


        public City(string name,int population)
        {
            Name = name;
            Population = population;
        }


        public int getPopulation() { return Population; }
        public string getName() { return Name; }

        public int? compareTo(City city)
        {
            if(city == this)
            {
                System.Console.WriteLine("WARN : SAME CITY");
            }
            if(city != null)
            {
                if (Population > city.Population)
                {
                    return 1;
                }
                else if (Population < city.Population)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

            return null;
           
        }
    }
}

