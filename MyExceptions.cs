using System;

namespace _7
{
    class DivisionException : Exception //Исключение из раздела
    {

        public DivisionException() : base("Attempted divide by zero.")
        {
        }
        public DivisionException(string message) : base(message)
        {
        }
        public DivisionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    class InputException : Exception //Исключение ввода
    {
        public InputException() : base("Incorreсt input price")
        {
        }
        public InputException(string message) : base(message)
        {
        }
        public InputException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    class WrongIndexException : Exception //Неверное исключение индекса
    {
        public WrongIndexException(string message) : base(message)
        {
        }
        public WrongIndexException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    class NaNException : Exception //Исключение NaN
    {
        public NaNException() : base("Not a number.")//конструктор по умолчанию со стандартным сообщением
        {
        }
        public NaNException(string message) : base(message)//конструктор с сообщением, которое мы можем установить сами
        {
        }
        public NaNException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
