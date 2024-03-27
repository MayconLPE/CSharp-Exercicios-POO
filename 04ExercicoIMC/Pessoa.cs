using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04ExercicoIMC
{
    public class Pessoa
    {
        public double peso, altura;

        public double calcIMC() 
        {
            return peso / (altura * altura);
        }
        
        public string situacaoIMC(double imc) {

            string retorno;


                if (imc < 18.5) 
                {
                    retorno = "Abaixo do peso";
                }
                else if (imc < 25)
                {
                    retorno = "peso normal";
                }
                else if (imc < 30)
                {
                    retorno = "Acima do peso";
                }
                else if (imc < 35)
                {
                    retorno = "Obesidade 1";
                }
                else if (imc < 40)
                {
                    retorno = "obesidade 2";
                }
                else{
                    retorno = "obesidade 3";
                } 

                return retorno;
        }

        // Mensagem
        public void mensagem()
        {
            // obter o cálculo
            double obterCalculo = calcIMC();

            // obter situação
            string obterSituacao = situacaoIMC(obterCalculo);

            // Exibir mensagem
            Console.WriteLine("Seu IMC é de " + obterCalculo);
            Console.WriteLine("Sua situação é " + obterSituacao);

        }
    }
}