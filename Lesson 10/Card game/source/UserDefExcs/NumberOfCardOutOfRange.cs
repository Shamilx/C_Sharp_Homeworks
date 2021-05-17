

namespace UserDefExcs
{
    class NumberOfCardOutOfRange : System.Exception
    {
        public NumberOfCardOutOfRange() {}

        public NumberOfCardOutOfRange(string msg) : base(msg)
        {}
    }
}