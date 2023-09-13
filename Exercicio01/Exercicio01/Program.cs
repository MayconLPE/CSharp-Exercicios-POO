using Exercicio01;

internal class Program
{
    private static void Main(string[] args)
    {
        // 01. Fazer um programa para ler os dados de duas pessoas,
        // depois mostrar o nome da pessoa mais velha.




        Console.WriteLine("Digite o Nome da 1° pessoa: ");
        string nome1 = Console.ReadLine();
        Console.WriteLine("Digite a idade da 1° pessoa: ");
        int idade1 = int.Parse(Console.ReadLine());

        Pessoa p1 = new Pessoa(nome1, idade1);


        Console.WriteLine("Digite o Nome da 2° pessoa: ");
        string nome2 = Console.ReadLine();
        Console.WriteLine("Digite a idade da 2° pessoa: ");
        int idade2 = int.Parse(Console.ReadLine());

        Pessoa p2 = new Pessoa(nome2, idade2);

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