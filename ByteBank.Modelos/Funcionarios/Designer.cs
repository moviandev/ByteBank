﻿namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * .17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
