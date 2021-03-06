﻿using System;
using System.Diagnostics;

namespace GFT
{
    /*3) Considerando os conceitos de Orientação a Objetos, crie uma classe abstrata Pai de
    nome Conta com os seguintes atributos (número, titular e saldo) e mais duas classes Filhas
    (ContaCorrente e ContaPoupanca). Na classe Conta deve existir um método de nome
    rendimento que retorna o rendimento mensal da conta, nas classes filhas deve existir o
    mesmo método rendimento, porém com as seguintes regras:
    Para ContaCorrente, o método rendimento deve retornar o saldo * 0.03;
    Para ContaPoupanca, o método rendimento deve retornar o saldo * 0.05;
    Por fim, criar uma classe principal que instancie objetos de ContaCorrente e
    ContaPoupanca, adicione no mínimo um valor para cada atributo e imprima cada conta
    (ContaCorrente e ContaPoupanca) com seus devidos rendimentos.
    Obs: Encapsular atributos das classes.
    4)Aproveitando o seu código já escrito na questão 3, crie uma interface chamada Imposto 
que contenha o método calcularImposto() e implemente ela em ContaCorrente e 
ContaPoupanca com a seguinte regra: 
    Para ContaCorrente, o método calcularImposto() deve retornar o rendimento * 25%;  
    Para ContaPoupanca, o método calcularImposto() deve retornar o rendimento * 10%; */
    public class Programa
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente() { Numero = 1234, Titular = "fjskfjslfs", Saldo = 1000 };
            ContaPoupanca cp = new ContaPoupanca() { Numero = 12341, Titular = "Fjskfjslfs", Saldo = 2000 };
            Console.WriteLine();
            //Console.WriteLine("Conta Corrente: {0} - {1} - {2} - {3}", cc.Numero, cc.Titular, cc.Saldo, cc.rendimento(cc.Saldo));
            //Console.WriteLine("Conta Poupança: {0} - {1} - {2} - {3}", cp.Numero, cp.Titular, cp.Saldo, cp.rendimento(cp.Saldo));
            Console.WriteLine("Conta Corrente: {0} - {1} - {2} - {3} - {4}", cc.Numero, cc.Titular, cc.Saldo, cc.rendimento(cc.Saldo), cc.calcularImposto(cc.rendimento(cc.Saldo)));
            Console.WriteLine("Conta Poupança: {0} - {1} - {2} - {3} - {4}", cp.Numero, cp.Titular, cp.Saldo, cp.rendimento(cp.Saldo), cp.calcularImposto(cp.rendimento(cc.Saldo)));
            Console.WriteLine();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
    public class Conta
    {
        private int numero;
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        private string titular;
        public string Titular
        {
            get
            {
                return this.titular;
            }
            set
            {
                this.titular = value;
            }
        }
        private double saldo;
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }
        public virtual double rendimento(double saldo)
        {
            return 0;
        }
    }
    public class ContaCorrente : Conta, IConta
    {
        public override double rendimento(double saldo)
        {
            return saldo * 0.03;
        }
        public double calcularImposto(double rendimento)
        {
            return rendimento * 0.25;
        }
    }
    public class ContaPoupanca : Conta, IConta
    {
        public override double rendimento(double saldo)
        {
            return saldo * 0.05;
        }
        public double calcularImposto(double rendimento)
        {
            return rendimento * 0.1;
        }
    }
    public interface IConta
    {
        double calcularImposto(double rendimento);
    }
}