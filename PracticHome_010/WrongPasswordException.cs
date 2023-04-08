namespace PracticHome_010
{
    class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message) { }
    }
}
