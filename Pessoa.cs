using System;
using System.Text;
using System.IO;
namespace _04ExercicioIMC
{
    public class Pessoa
    {   
        public string nome;
        public double peso, altura;
        string caminho = "C:\\Codigos\\DadosUsuarioIMC.txt";

        public double imc()
        {
            return peso / (altura * altura);
        }
        public string situacao(double imc)
        {
            string retorno_S;

            if (imc < 18.5)
            {
                retorno_S = "Abaixo do peso.";
            }
            else if (imc < 25)
            {
                retorno_S = "Peso Normal.";
            }
            else if (imc < 30)
            {
                retorno_S = "Acima do Peso.";
            }
            else if (imc < 35)
            {
                retorno_S = "Obesidade I";
            }
            else if (imc < 40)
            {
                retorno_S = "Obesidade II";
            }
            else
            {
                retorno_S = "Obesidade III";
            }
            return retorno_S;
        }   
        public void mensagem()
        {   
            double obterimc = imc();
            string obterSituacao = situacao(obterimc);

            Console.WriteLine(nome+", você tem "+obterimc.ToString("F")+" de IMC.");
            Console.WriteLine();
            Console.WriteLine("Sua situação é: "+obterSituacao);
            Console.WriteLine();
            Console.WriteLine("Cálculo realizado: "+peso+" / ("+altura+" * "+altura+")");
        }

        public void gravaDados()
        {   
            double obterimc = imc();
            string obterSituacao = situacao(obterimc);
            StreamWriter dados = new StreamWriter(caminho, true, Encoding.ASCII);

            dados.WriteLine("Nome: "+nome);
            dados.WriteLine("IMC: "+imc());
            dados.WriteLine("Situacao: "+obterSituacao);

            Console.WriteLine("Dados gravados com sucesso!");
            dados.Close();
        }
        public void lerDados()
        {
            StreamReader dadosL = new StreamReader(caminho);

            while(dadosL.EndOfStream!=true)
            {
                Console.WriteLine(dadosL.ReadLine());
            }
            dadosL.Close();
        }


    }

}