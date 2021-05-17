using System.Collections.Generic;


namespace source
{
    class Player
    {
        private string _name;
        private List<Card> UsersCards;
        private int _points;


        public Player(string name)
        {
            _name = name;
            UsersCards = new();
        }


        public void GiveCard(Card obj)
        {
            UsersCards.Add(obj);
        }

        public List<Card> GetCards() { return UsersCards; }

        public int CalculatePoints()
        {
            if(UsersCards == null)
                throw new UserDefExcs.UserCardsIsNull("You need to give cards to Player first");
            
            int sumOfPoints = 0;

            foreach(var i in UsersCards)
            {
                sumOfPoints += i.GetPointsOfCard();
            }

            return sumOfPoints;
        }

        public string GetName() { return _name; }
        public int GetPoints() { return _points; }
    }
}