using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Designer
        // N - ...
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            // não é uma boa prática
            if (_tipo == 1)
                return Salario;

            return Salario * 0.10;
        }
    }
}
