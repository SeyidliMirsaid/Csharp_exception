
namespace Exceptions_Homework_06._12_25.Exception
{
    internal class NegativeNumberException : System.Exception
    {
        //public NegativeNumberException() { }
        public NegativeNumberException() : base("Number is Negative (Menfi ededdir.)") {}
        public NegativeNumberException(string message) : base("Aricmetic's operations was not chosen. (123)") {}
    }
}
