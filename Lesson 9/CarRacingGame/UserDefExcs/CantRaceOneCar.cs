using System;

namespace UserDefExcs
{
    class CantRaceOnecar : Exception
    {
        public CantRaceOnecar(string message) : base(message)
        {
        }
    }
}