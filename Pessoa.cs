using System;
namespace _04ExercicioIMC
{
    public class Pessoa
    {   
        public string nome;
        public double peso, altura;

        public double imc()
        {
            return peso / (altura * altura);
        }
        public string situacao(double imc)
        {
            string retorno;

            if (imc < 18.5)
            {
                retorno = "Abaixo do peso.";
            }
            else if (imc < 25)
            {
                retorno = "Peso Normal.";
            }
            else if (imc < 30)
            {
                retorno = "Acima do Peso.";
            }
            else if (imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if (imc < 40)
            {
                retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidade III";
            }
            return retorno;
        }   
        public void mensagem()
        {   
            double obterimc = imc();
            string obterSituacao = situacao(obterimc);

            Console.WriteLine(nome+" você tem "+obterimc.ToString("F")+" de IMC. Sua situação é: "+obterSituacao);
            Console.WriteLine("Cálculo realizado: "+peso+" / ("+altura+" * "+altura+")");
        }

    }

}