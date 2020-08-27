using System;

namespace GFT
{
    /*2) Crie uma Classe Pessoa, contendo os atributos (nome, endereço e telefone)
encapsulados, com seus respectivos seletores (getters) e modificadores (setters), e ainda o
construtor padrão. Por fim, criar uma classe principal que instancie o objeto Pessoa,
adicione no mínimo um valor para cada atributo e imprima na tela.*/
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa Joaquim = new Pessoa();
            Joaquim.Endereco = "Rua quatro, 55";
            Joaquim.Nome = "Joaquim da Silva";
            Joaquim.Telefone = "(11) 9999-9999";
            Console.WriteLine();
            Console.WriteLine(Joaquim.Endereco);
            Console.WriteLine(Joaquim.Nome);
            Console.WriteLine(Joaquim.Telefone);
            Console.WriteLine();
        }
    }
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        private string endereco;
                public string Endereco
        {
            get
            {
                return this.endereco;
            }
            set
            {
                this.endereco = value;
            }
        }
        private string telefone;
                public string Telefone
        {
            get
            {
                return this.telefone;
            }
            set
            {
                this.telefone = value;
            }
        }
        public Pessoa()
        {

        }

    }
}