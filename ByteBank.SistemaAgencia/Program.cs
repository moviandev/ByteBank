﻿using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Lista<int> idades;

            Console.ReadLine();
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