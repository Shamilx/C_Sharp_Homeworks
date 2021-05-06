using System;


namespace UserDefExcs
{
    class CantFindType : Exception
    {
        public CantFindType(string message) : base(message)
        {

        }
    }
}