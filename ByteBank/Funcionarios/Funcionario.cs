﻿using System;

namespace ByteBank.Funcionarios
{
    abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }

        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Designer
        // N - ...
        //private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario)
        {
            Console.WriteLine("Criando funcionario");
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
