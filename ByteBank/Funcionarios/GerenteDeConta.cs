using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Autenticavel
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000)
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
