using System;
using System.Runtime.Serialization;

namespace source
{
    [Serializable]
    internal class NumberIsNullException : Exception
    {
        public NumberIsNullException() {}

        public NumberIsNullException(string message) : base(message) {}
    }
}