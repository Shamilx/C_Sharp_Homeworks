using System;
using System.Runtime.Serialization;

namespace UserDefExcs
{
    class NameIsNullException : Exception
    {
        public NameIsNullException() {}

        public NameIsNullException(string message) : base(message) {}
    }
}