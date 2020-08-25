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
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();
            cc.
        }
    }
    public class Conta
    {
        protected int numero { get; set; }
        private string titular { get; set; }
        protected double saldo { get; set; }
        public void rendimento()
        {
            
        }
    }
    public class ContaCorrente : Conta
    {
        public double rendimento()
        {
            return saldo * 0.03;
        }
    }
    public class ContaPoupanca : Conta
    {
        public double rendimento()
        {
            return saldo * 0.05;
        }
    }
}