using System;

class Pessoa
{
    // ATRIBUTO
    private string nome = "Leandro";

    // CONSTRUTOR
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}