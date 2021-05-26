using System;


namespace src.Exceptions
{
    class UsernameOrPasswordIncorrect : Exception
    {
        public UsernameOrPasswordIncorrect() {}
        public UsernameOrPasswordIncorrect(string msg) : base(msg) {}
    }
}