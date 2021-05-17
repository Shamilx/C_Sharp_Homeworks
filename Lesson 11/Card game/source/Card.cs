
using System;

namespace source
{
    class Card
    {

        private string _typeOfCard;
        private string _nameOfCard; // Jack,King,Queen

        private int? _numberOfCard;
        private int points;



        // (diamonds,5)
        public Card(string TypeOfCard,int NumberOfCard)
        {
            TypeOfCard = TypeOfCard.ToLower();

            _typeOfCard = TypeOfCard;
            _numberOfCard = NumberOfCard;

            _nameOfCard = null;

            calculatePoints();
        }

        // For handling cards like Jack,King (jack,hearts)
        public Card(string NameOfCard,string TypeOfCard)
        {
            NameOfCard = NameOfCard.ToLower();
            TypeOfCard = TypeOfCard.ToLower();

            _nameOfCard = NameOfCard;
            _typeOfCard = TypeOfCard;

            _numberOfCard = null;

            calculatePoints(); // For defining points to card
        }

        public string GetInfoAboutCard()
        {
            if(_nameOfCard == null)
                return _typeOfCard + "\t" + _numberOfCard;

            if(_numberOfCard == null)
                return _nameOfCard + "\t" + _typeOfCard;
            
            return null;
        }

        public string GetNameOfCard() 
        {
            if(_nameOfCard == null)
                throw new UserDefExcs.NameIsNullException("This card's name field is null!");

            return _nameOfCard;
        }

        public string GetTypeOfCard()
        {
            if(_typeOfCard == null)
                throw new UserDefExcs.TypeIsNullException("This card's type field is null!");
            
            return _typeOfCard;
        }   

        public int GetNumberOfCard()
        {
            if(_numberOfCard == null)
                throw new NumberIsNullException("This card's number field is null!");

            return _numberOfCard ?? 0;
        }

        public int GetPointsOfCard()
        {
            return points;
        }

        private void calculatePoints()
        {
            if(_nameOfCard == null)
            {
                calculatePointsForFirstCtor();
            }

            if(_numberOfCard == null)
            {
                calculatePointsForSecondCtor();
            }
        }
        
        private void calculatePointsForFirstCtor()
        {
            int sumOfPoints = 0;

            sumOfPoints += CheckPointsForType(_typeOfCard);
            
            if(_numberOfCard > 6 || _numberOfCard <= 0)
                throw new UserDefExcs.NumberOfCardOutOfRange("Please check the number that you sent,number's range is from 1 to 6. You sent " + _numberOfCard);

            sumOfPoints += _numberOfCard ?? 0;

            points = sumOfPoints;
        }

        private void calculatePointsForSecondCtor()
        {
            int sumOfPoints = 0;

            sumOfPoints += CheckPointsForType(_typeOfCard);
            sumOfPoints += CheckPointsForName(_nameOfCard);

            points = sumOfPoints > 10 ? 10 : sumOfPoints;
        }

        private int CheckPointsForType(string type)
        {
            switch(type)
            {
                case "spades":
                    return 4;
                case "hearts":
                    return 3;
                case "diamonds":
                    return 2;
                case "clubs":
                    return 1;
            }

            throw new UserDefExcs.NameIsInvalid("Check sent name to ctor and try again!,you can check cards.txt too");

        }

        private int CheckPointsForName(string name)
        {
            switch(name)
            {
                case "jack":
                    return 4;
                case "queen":
                    return 5;
                case "king":
                    return 6;
            }

            throw new UserDefExcs.WrongParametrs("You must send something to second ctor like jack,hearts.");
        }
    }
}