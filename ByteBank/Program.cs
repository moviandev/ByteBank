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

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "123456789123";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "99999999999999";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine($"Bonificacao de uma referencia de um Diretor {roberta.GetBonificacao()}");
            Console.WriteLine($"Total de bonificações {gerenciador.GetTotalBonificacao()}");

            Console.WriteLine($"Total funcionarios {Funcionario.TotalDeFuncionarios}");

            Console.ReadLine();
        }
    }
}
