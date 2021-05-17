
namespace UserDefExcs
{
    class NameIsInvalid : System.Exception
    {
        public NameIsInvalid() {}

        public NameIsInvalid(string message) : base(message)
        {}
    }
}