namespace ByteBank.Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        private AutenticacaoHelper _autenticacoHelper = new AutenticacaoHelper();

        public FuncionarioAutenticavel(string cpf, double salario, string senha) : base(cpf, salario)
        {
            Senha = senha;
        }

        public bool Autenticar(string senha)
        {
            return _autenticacoHelper.CompararSenhas(Senha, senha);
        }
    }
}
