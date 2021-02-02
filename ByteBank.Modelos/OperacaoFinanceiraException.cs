using System;

namespace ByteBank.Modelos
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        { }

        public OperacaoFinanceiraException(string message) : base(message)
        { }

        public OperacaoFinanceiraException(string message, Exception exception) : base(message, exception)
        { }
    }
}
