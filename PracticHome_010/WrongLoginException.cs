﻿namespace PracticHome_010
{
    class WrongLoginException : Exception
    {
        public WrongLoginException(string message) : base(message) { }
    }
}
