

namespace Exceptions
{
    class FileExsists : System.Exception
    {
        public FileExsists() {}
        public FileExsists(string msg) : base(msg) {}
    }
}