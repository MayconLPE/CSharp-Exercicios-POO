using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03NotaMedia
{
    public class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;


        public double media() 
        {
            return (nota1+nota2)/2;
        }

        public string SituacaoMedia(double media) 
        {
            return media >= 7 ? "Aprovado" : "Reprovado";
        }

        public void mensagem()
        {
            double obterMedia = media();

            string obterSituacao = SituacaoMedia(obterMedia);

            Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
        }
        
    }
}