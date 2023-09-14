﻿using ContaBanco;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta;


        Console.Write("Digite o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre com o titular(Nome) da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Deseja depositar (s/n)? ");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S')
        {
            Console.Write(" Entre o valor de depósito inicial: ");
            double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta = new ContaBancaria(numero, titular, depositoInicial);
        }
        else
        {
            conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta);
    }
}