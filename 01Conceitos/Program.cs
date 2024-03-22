using _01Conceitos;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Pessoa p1 = new Pessoa();

        Console.WriteLine("Digite seu nome: ");
        p1.nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        p1.idade = int.Parse(Console.ReadLine());

        p1.mensagem();

        
    }
}