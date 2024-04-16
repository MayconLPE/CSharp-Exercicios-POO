using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06Encapsulamento
{
    public class Aluno
    {
        private double nota1, nota2;

        private double media() {
            return (nota1 + nota2)/2;
        }

        public void mensagem()
        {
            
        }
    }
}