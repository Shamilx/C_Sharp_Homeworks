using System;

namespace src.Exceptions
{
    class InvalidInputException : Exception
    {
        public InvalidInputException() {}
        public InvalidInputException(string msg) : base(msg) {}
    }
}