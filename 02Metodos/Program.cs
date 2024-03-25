using _02Metodos;


internal class Program
{
    private static void Main(string[] args)
    {
        
        Pessoa p1 = new Pessoa();
        p1.apresentar();

        p1.apresentar("Maycon");

        p1.apresentar("Maycon", 31);
    }
}