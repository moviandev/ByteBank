using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf, string senha) : base(cpf, 4000, senha)
        {

        }
        public override double GetBonificacao()
        {
            return Salario * .25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}
