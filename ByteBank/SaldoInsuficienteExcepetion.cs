using System;

namespace ByteBank
{
    public class SaldoInsuficienteExcepetion : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteExcepetion()
        { }

        public SaldoInsuficienteExcepetion(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteExcepetion(double saldo, double valorSaque)
            : this($"Tentativa do saque do valor {valorSaque} em uma conta com o saldo de {saldo}")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
