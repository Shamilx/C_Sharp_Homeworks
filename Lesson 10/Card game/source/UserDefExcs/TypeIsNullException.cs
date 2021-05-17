using System;
using System.Runtime.Serialization;

namespace UserDefExcs
{
    class TypeIsNullException : Exception
    {
        public TypeIsNullException() {}

        public TypeIsNullException(string message) : base(message) {}
    }
}