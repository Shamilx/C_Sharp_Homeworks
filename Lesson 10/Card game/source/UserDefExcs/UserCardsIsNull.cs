using System;
using System.Runtime.Serialization;

namespace UserDefExcs
{
    [Serializable]
    internal class UserCardsIsNull : Exception
    {
        public UserCardsIsNull() {}

        public UserCardsIsNull(string message) : base(message) {}
    }
}