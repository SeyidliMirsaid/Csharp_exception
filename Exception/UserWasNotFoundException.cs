
namespace Exceptions_06_12_25.Exception
{
    internal class UserWasNotFoundException : System.Exception
    {
        public UserWasNotFoundException() {}

        public UserWasNotFoundException(string userName) : base($"{userName} was not found") {}

        public UserWasNotFoundException(string message, System.Exception ex) : base($"Occured any problem {message}", ex) {}
    }
}
