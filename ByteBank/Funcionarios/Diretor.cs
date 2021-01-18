using ByteBank.Sistemas;
using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf, string senha) : base(cpf, 5000, senha)
        {
            Console.WriteLine("Criando diretor");
        }

        public override double GetBonificacao()
        {
            return Salario * .5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
