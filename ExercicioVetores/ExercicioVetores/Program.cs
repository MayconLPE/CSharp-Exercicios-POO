﻿using ExercicioVetores;

internal class Program
{
    /*
        A dona de um pensionato possui dez quartos para alugar para estudantes,
        sendo esses quartos identificados pelos números 0 a 9.
        Quando um estudante deseja alugar um quarto, deve-se registrar o nome
        e email deste estudante.
        Fazer um programa que inicie com todos os dez quartos vazios, e depois
        leia uma quantidade N representando o número de estudantes que vão
        alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
        N estudantes. Para cada registro de aluguel, informar o nome e email do
        estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
        que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
        um relatório de todas ocupações do pensionato, por ordem de quarto,
        conforme exemplo.
    */
    private static void Main(string[] args)
    {
        Estudantes[] vect = new Estudantes[10];

        Console.WriteLine("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Aluguel #{i}: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            vect[quarto] = new Estudantes(nome, email);
        }
        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");
        for (int i = 0; i < vect.Length; i++)
        {
            if (vect[i] != null)
            {
                Console.WriteLine(i + ": " + vect[i]);
            }
        }
    }
}