


namespace UserDefExcs
{
    class WrongParametrs : System.Exception
    {
        public WrongParametrs() {}
        
        public WrongParametrs(string msg) : base(msg) {}
    }
}