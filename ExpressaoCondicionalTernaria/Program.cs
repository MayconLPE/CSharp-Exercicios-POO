using System.Globalization;
internal class Program

{
    private static void Main(string[] args)
    {      
        Console.Write("Digite o preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
        Console.WriteLine(desconto);
    }
}