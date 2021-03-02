﻿namespace ByteBank.Modelos.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * .2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}