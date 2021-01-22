using System;

namespace ByteBank
{
    public class SaldoInsuficienteExcepetion : Exception
    {
        public SaldoInsuficienteExcepetion()
        { }

        public SaldoInsuficienteExcepetion(string mensagem) : base(mensagem)
        {

        }
    }
}
