using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Comparers
{
    public class ContaCorrenteComparer : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
                return 0;
            else if (x == null)
                return 1;
            else if (y == null)
                return -1;
            else
                return x.Agencia.CompareTo(y);
        }
    }
}