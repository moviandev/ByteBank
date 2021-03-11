using System;
using System.Collections.Generic;
using System.Linq;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparers;
using ByteBank.SistemaAgencia.Extensoes;
using System.IO;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    public static partial class Program
    {
        public static void StreamReader(string[] args)
        {
            Console.ReadLine();
        }

        public static ContaCorrente ConvertStringToContaCorrente(string line)
        {
            var fields = line.Split(' ');

            var agency = fields[0];
            var account = fields[1];
            var limit = fields[2].Replace('.', ',');
            var titualr = fields[3];

            var intAgency = int.Parse(agency);
            var intAccount = int.Parse(account);
            var doubleLimit = double.Parse(limit);

            var costumer = new Cliente();
            costumer.Nome = titualr;
            var result = new ContaCorrente(intAgency, intAccount);
            result.Depositar(doubleLimit);
            result.Titular = costumer;

            return result;
        }
    }
}