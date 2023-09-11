using Exercicio01;

internal class Program
{
    private static void Main(string[] args)
    {
        // 01. Fazer um programa para ler os dados de duas pessoas,
        // depois mostrar o nome da pessoa mais velha.

        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();

        Console.WriteLine("Digite o Nome da 1° pessoa: ");
        p1.nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da 1° pessoa: ");
        p1.idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Nome da 2° pessoa: ");
        p2.nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da 2° pessoa: ");
        p2.idade = int.Parse(Console.ReadLine());

        if (p1.idade > p2.idade)
        {
            Console.WriteLine(p1.nome + " é mais velho(a) que " + p2.nome);
        }
        else if (p2.idade > p1.idade)
        {
            Console.WriteLine(p2.nome + " é mais velho(a) que " + p1.nome);
        }
        else
        {
            Console.WriteLine("Mesma idade");
        }

    }
}