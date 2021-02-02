using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(222, 2222222);

            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}