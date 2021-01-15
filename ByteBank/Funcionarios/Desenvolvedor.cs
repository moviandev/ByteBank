namespace ByteBank.Funcionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.3;
        }

        public override double GetBonificacao()
        {
            return Salario * .4;
        }
    }
}
