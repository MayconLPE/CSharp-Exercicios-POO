using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Imposto objetoE = new Estagiario();
        objetoE.valeAlimentacao(1000);
        objetoE.valeTransporte(1000);
        Console.WriteLine("------------");

        Imposto objetoG = new Gerente();
        objetoG.valeAlimentacao(5000);
        objetoG.valeTransporte(5000);
        Console.WriteLine("------------");


        Imposto objetoA = new Atendente();
        objetoA.valeAlimentacao(2000);
        objetoA.valeTransporte(2000);

    }
}