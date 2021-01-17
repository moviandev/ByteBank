using ByteBank.Sistemas;
using System;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel
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
