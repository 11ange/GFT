using System;

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
    Obs: Encapsular atributos das classes.*/
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente() { Numero = 1234, Titular = "fjskfjslfs", Saldo = 1000 };
            ContaPoupanca cp = new ContaPoupanca() { Numero = 12341, Titular = "Fjskfjslfs", Saldo = 2000 };
            Console.WriteLine();
            Console.WriteLine("Conta Corrente: {0} - {1} - {2} - {3}", cc.Numero, cc.Titular, cc.Saldo, cc.rendimento(cc.Saldo));
            Console.WriteLine("Conta Poupança: {0} - {1} - {2} - {3}", cp.Numero, cp.Titular, cp.Saldo, cp.rendimento(cp.Saldo));
            Console.WriteLine();
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
    public class ContaCorrente : Conta
    {
        public override double rendimento(double saldo)
        {
            return saldo * 0.03;
        }
    }
    public class ContaPoupanca : Conta
    {
        public override double rendimento(double saldo)
        {
            return saldo * 0.05;
        }
    }
}