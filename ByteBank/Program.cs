using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonficacao gerenciadorBonficacao = new GerenciadorBonficacao();

            Designer pedro = new Designer("123.123.123-45");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("123.456.789-10");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("987.765.432-10");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("456.987.123-67");
            camila.Nome = "Camila";

            gerenciadorBonficacao.Registrar(pedro);
            gerenciadorBonficacao.Registrar(roberta);
            gerenciadorBonficacao.Registrar(igor);
            gerenciadorBonficacao.Registrar(camila);

            Console.WriteLine($"Total de bonificacao do mês {gerenciadorBonficacao.GetTotalBonificacao()}");
        }
    }
}
