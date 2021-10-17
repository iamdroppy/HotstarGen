using System;

namespace HotstarGen
{
    class SafeException : Exception
    {
        public SafeException(string message) : base(message)
        {
            
        }
    }
}