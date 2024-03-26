using _03NotaMedia;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a = new Aluno();

        Console.WriteLine("Digite o seu nome:  ");
        a.nome = Console.ReadLine();
        Console.WriteLine("Digite a primeira Nota: ");
        a.nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda Nota: ");
        a.nota2 = double.Parse(Console.ReadLine());
       
        a.mensagem();
    }
}