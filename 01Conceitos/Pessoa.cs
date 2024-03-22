using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01Conceitos
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public void mensagem()
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
        }
    }
}