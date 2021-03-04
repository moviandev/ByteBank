﻿using System;

namespace ByteBank.Modelos
{
    public class ContaCorrente : IComparable
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public static double TaxaOperacao { get; set; }

        public int ContadorDeSaquesNaoPermitidos { get; private set; }
        public int ContadorDeTransferenciasNaoPermitidos { get; private set; }

        public int Agencia
        { get; }

        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("Agencia com valor inválido", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("Número com valor inválido", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public bool Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException($"Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorDeSaquesNaoPermitidos++;
                throw new SaldoInsuficienteExcepetion(Saldo, valor);
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException($"Valor inválido para o saque.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteExcepetion e)
            {
                ContadorDeTransferenciasNaoPermitidos++;
                throw new OperacaoFinanceiraException("Operação não realizada", e);
            }
            contaDestino.Depositar(valor);
        }

        public override bool Equals(object obj)
        {
            ContaCorrente anotherCount = obj as ContaCorrente;

            if (anotherCount is null)
                return false;

            return Numero == anotherCount.Numero && Agencia == anotherCount.Agencia;
        }

        public override int GetHashCode()
        {
            return Numero;
        }

        public int CompareTo(object obj)
        {
            // Retornar negativo quando a instância precede o obj
            // Retornar 0 quando nossa instancia e obj for equivalentes
            // Retornar positivo diferente de 0 quando a precedencia for de obj

            // Aqui usamos "as" por conta se obj for null vamos passar nullo
            var outraConta = obj as ContaCorrente;

            if (outraConta is null || Numero < outraConta.Numero)
                return -1;
            else if (Numero == outraConta.Numero)
                return 0;
            else
                return 1;
        }
    }
}