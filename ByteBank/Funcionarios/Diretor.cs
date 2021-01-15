using System;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000)
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
