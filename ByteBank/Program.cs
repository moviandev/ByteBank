using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    static class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonficacao gerenciador = new GerenciadorBonficacao();

            Funcionario carlos = new Funcionario("123456789123", 2000);

            carlos.Nome = "Carlos";

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("99999999999999", 5000);
            roberta.Nome = "Roberta";

            gerenciador.Registrar(roberta);

            Console.WriteLine($"Bonificacao de uma referencia de um Diretor {roberta.GetBonificacao()}");
            Console.WriteLine($"Total de bonificações {gerenciador.GetTotalBonificacao()}");

            Console.WriteLine($"Total funcionarios {Funcionario.TotalDeFuncionarios}");

            Console.ReadLine();
        }
    }
}
