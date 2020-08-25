﻿using System;

namespace GFT
{
    /*1) Elabore um algoritmo para mostrar os números ímpares existentes em um intervalo. O
    usuário deverá fornecer os valores inicial (inicial > 0) e final (inicial < final) e os números
    ímpares existentes no intervalo ([inicial, final]) devem ser separados por um espaço em
    branco.
    Exemplo:
    Entrada: 2 13
    Saída: 3 5 7 9 11 13*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Mostra números impares no intervalo definido");
            Console.WriteLine();
            Console.Write("Entre com o início e final do intervalo separados por espaço: ");
            int[] intervalo = Array.ConvertAll(Console.ReadLine().Split(' '), (item) => Convert.ToInt32(item));
            Console.WriteLine();
            
            int inicio = intervalo[0];
            int final = intervalo[1];

            for (int i = inicio; i <= final; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}