using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("123.456.789-10");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");

            GerenteDeConta camila = new GerenteDeConta("456.987.123-67");
            camila.Nome = "Camila";
            camila.Senha = "abc";
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(camila, "123");
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
