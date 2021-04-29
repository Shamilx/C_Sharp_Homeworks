
using System;

namespace Exceptions
{
    class TankAlreadyDestroyed : Exception
    {
        public TankAlreadyDestroyed() { }

        public TankAlreadyDestroyed(string message)
            : base(message) { }

        public TankAlreadyDestroyed(string message, Exception inner)
            : base(message, inner) { }
    }
}