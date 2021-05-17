using System;
using System.Collections.Generic;

namespace source
{
    class Game
    {
        private List<Player> _players;

        public Game(List<Player> players)
        {
            _players = players;
        }


        public void StartGame()
        {
            List<Card> Cards = GenerateCards();

            ShuffleCards(Cards,_players);

            Play();
        }

        private void Play()
        {
            Player winner = null;
            int max = 0;
            
            int points = 0;

            foreach(var i in _players)
            {
                points = i.CalculatePoints();

                if(points > max)
                {
                    max = points;
                    winner = i;
                }
            }

            System.Console.WriteLine("Winner is " + winner.GetName());
        }

        private static void ShuffleCards(List<Card> Cards,List<Player> Players)
        {
            int playersCount = Players.Count;
            int cardsCount = Cards.Count;

            int cardsForEachPlayer = cardsCount / playersCount;

            int copy = cardsForEachPlayer;
            int num = 0;

            for(int i = 0;i < Players.Count;i++)
            {
                for(int j = num;j < cardsForEachPlayer;j++)
                {
                    Players[i].GiveCard(Cards[j]);
                }

                num += copy;
                cardsForEachPlayer = cardsForEachPlayer + copy;
            }
        }

        private static List<Card> GenerateCards()
        {
            Random rm = new();

            List<Card> ListOfCards = new();

            string[] Cards = 
            {
                "Clubs",
                "Diamonds",
                "Hearts",
                "Spades",
                "Jack",
                "Queen",
                "King"
            };

            string randomSelectedName;
            string randomSelectedType;

            int randomNumber;

            short randomIndex;

            for(int i = 0;i < 36;i++)
            {
                randomIndex = (short)rm.Next(0,7);

                if(randomIndex > 3)
                {
                    randomSelectedName = Cards[randomIndex];
                    randomSelectedType = Cards[rm.Next(0,4)];

                    ListOfCards.Add(new Card(randomSelectedName,randomSelectedType));
                    continue;
                }
                else
                {
                    randomSelectedType = Cards[randomIndex];
                    randomNumber = rm.Next(1,6);

                    ListOfCards.Add(new Card(randomSelectedType,randomNumber));
                }
            }

            return ListOfCards;
        }
    }
}