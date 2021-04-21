
namespace SevenWonders
{
    class Base
    {
        string Location;
        string ConstructionDate;
 

        protected Base(string loc,string date)
        {
            Location = loc;
            ConstructionDate = date;
        }

        public string getLocation() { return Location; }
        public string getConstructionDate() { return ConstructionDate; }
    }

    class ChinaGreatWall : Base
    {
        public ChinaGreatWall() : base("China","B.C 214") {}
    }

    class ChicenItza : Base
    {
        public ChicenItza() : base("Mexico", "400s A.D.") {}
    }

    class Petra : Base
    {
        public Petra() : base("Jordan", "5th century BC") {}
    }

    class MachuPicchu : Base
    {
        public MachuPicchu() : base("Peru", "15th-16th ceuntry") {}
    }

    class ChristtheRedeemer : Base
    {
        public ChristtheRedeemer() : base("Brazil", "April 4, 1922") {}
    }

    class Colosseum : Base
    {
        public Colosseum() : base("Italy", "70 AD") {}
    }

    class TajMahal : Base
    {
        public TajMahal() : base("India", "1631") {}
    }
}