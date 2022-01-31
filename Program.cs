using System;

namespace _04ExercicioIMC
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa a = new Pessoa();
            
            Console.WriteLine("Qual é o seu nome?");
            a.nome = Console.ReadLine();
            Console.WriteLine("Qual é o seu peso?");
            a.peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a sua altura?");
            a.altura = double.Parse(Console.ReadLine());

            a.mensagem();
        }
    }
}