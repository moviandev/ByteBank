﻿using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 123456789);
                ContaCorrente conta2 = new ContaCorrente(123, 123456789);
                conta.Depositar(50000);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine(conta.Saldo);

                conta2.Transferir(1000000, conta);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Argumento com problema {e.ParamName}");
            }
            catch (SaldoInsuficienteExcepetion e)
            {
                Console.WriteLine(e.Saldo);
                Console.WriteLine(e.ValorSaque);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("123.456.789-10", "abc");
            roberta.Nome = "Roberta";
            sistemaInterno.Logar(roberta, "abc");
            sistemaInterno.Logar(roberta, "123");

            GerenteDeConta camila = new GerenteDeConta("456.987.123-67", "123");
            camila.Nome = "Camila";
            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(camila, "abc");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonficacao gerenciadorBonficacao = new GerenciadorBonficacao();

            Designer pedro = new Designer("123.123.123-45");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("123.456.789-10", "abc");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("987.765.432-10");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("456.987.123-67", "123");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("234.987.546-09");
            guilherme.Nome = "Guilherme";

            gerenciadorBonficacao.Registrar(pedro);
            gerenciadorBonficacao.Registrar(roberta);
            gerenciadorBonficacao.Registrar(igor);
            gerenciadorBonficacao.Registrar(camila);
            gerenciadorBonficacao.Registrar(guilherme);

            Console.WriteLine($"Total de bonificacao do mês {gerenciadorBonficacao.GetTotalBonificacao()}");
        }
    }
}
