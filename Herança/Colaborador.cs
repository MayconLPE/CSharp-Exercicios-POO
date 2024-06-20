

class Colaborador : Pessoa
{
    // atributo
    private double salario;

    // construtor
    public Colaborador(string nome, inte idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    // método
    protected void mensagemColaborador()
    {
        Console.WriteLine($"Salário: {salario}");
    }

}