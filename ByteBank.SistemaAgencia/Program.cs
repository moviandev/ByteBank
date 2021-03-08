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
        public static void Main(string[] args)
        {
            var filePath = "contas.txt";

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var buffer = new byte[1024];
                var readBytesQuantity = -1;

                while (readBytesQuantity != 0)
                {
                    readBytesQuantity = fileStream.Read(buffer, 0, 1024);
                    WriteBuffer(buffer, readBytesQuantity);
                }
            }

            Console.ReadLine();
        }

        public static void WriteBuffer(byte[] buffer, int readBytes)
        {
            var utf8 = Encoding.Default;

            var text = utf8.GetString(buffer, 0, readBytes);

            Console.Write(text);

            //foreach (var myByte in buffer)
            //{
            //    Console.Write(myByte);
            //    Console.Write("  ");
            //}
        }

        public static void TestaLinq()
        {
            var contas = new List<ContaCorrente>();

            contas.AddRange(new ContaCorrente(122323, 123123), new ContaCorrente(235639, 920312308), new ContaCorrente(34987346, 4589230), null);

            var contasOrdenadas = contas
                .Where(d => d != null)
                .OrderBy(conta => conta?.Numero)
                .ToList();

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta?.Numero}");
            }
        }

        public static void TestaSort()
        {
            var idades = new List<int>();
            var nomes = new List<string>();

            nomes.AddRange("Matheus", "Guilherme", "Beatriz", "Flavia");

            nomes.Sort();

            idades.Add(1);

            idades.AddRange(12, 23, -1, -4, 234, 12, 90);

            idades.Sort();

            var contas = new List<ContaCorrente>();

            contas.AddRange(new ContaCorrente(122323, 123123), new ContaCorrente(235639, 920312308), new ContaCorrente(34987346, 4589230));

            contas.Sort(new ContaCorrenteComparer());

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}");
            }

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            foreach (var item in idades)
            {
                Console.WriteLine(item);
            }
        }

        private static void TestaListaDeContaCorrente()
        {
            ListaContaCorrente lista = new ListaContaCorrente();
            ContaCorrente contaDoGui = new ContaCorrente(111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(12345, 1234567890),
                new ContaCorrente(12345, 1234567890),
                new ContaCorrente(12345, 1234567890)
            };

            lista.AdicionarVarios(contas);

            for (var i = 0; i <= lista.Length - 1; i++)
            {
                var item = lista.GetItemNoIndice(i);

                Console.WriteLine($"Item no indice {i}: Conta: {item.Agencia} Numero: {item.Numero}");
            }
        }

        private static void TestaContaArray()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(12345, 1234567890),
                    new ContaCorrente(1234, 12567890),
                    new ContaCorrente(1345, 1237890)
                };

            for (var i = 0; i <= contas.Length - 1; i++)
            {
                Console.WriteLine($"Conta {i} {contas[i].Numero}");
            }
        }

        private static void TestaArrayInt()
        {
            int[] idades = new int[6];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 10;

            var idadeNoIndice4 = idades[4];

            Console.WriteLine(idadeNoIndice4);

            var acc = 0;

            for (int i = 0; i <= idades.Length - 1; i++)
            {
                var idade = idades[i];
                Console.WriteLine($"Acessando idade no indice {i}, idade: {idade}");
                acc += idade;
            }

            var average = acc / idades.Length;

            Console.WriteLine($"Media de idades == {average}");
        }
    }
}