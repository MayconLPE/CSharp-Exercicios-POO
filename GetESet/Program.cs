using System;
namespace GetESet
{
    internal class Program
{
    private static void Main(string[] args)
    {
       Pessoa p = new Pessoa();
       Console.WriteLine("Digite seu nome");
       p.Nome = Console.ReadLine();
       Console.WriteLine($"Meu nome é {p.Nome}");
    }
}
    
}
