using System;
using System.Text;
using System.IO;

namespace _04ExercicioIMC
{
    public class Program
    {
        static void Main(string[] args)
        {
            string escolhaUsuario = "";
            Pessoa a = new Pessoa();

            Console.WriteLine();
            Console.WriteLine("I- Verificar IMC");
            Console.WriteLine("L- Ler dados cadastrados");
            Console.WriteLine("S- Sair");
            Console.WriteLine();
            Console.WriteLine("Digite uma operação.");

            escolhaUsuario = Console.ReadLine().ToUpper();

            while (escolhaUsuario != "S")
            {
                if(escolhaUsuario == "I")
                {   
                    string escolhaUsuarioG = "";

                    Console.WriteLine("Informe o seu nome: ");
                    a.nome = Console.ReadLine();
                    Console.WriteLine("Informe o seu peso: ");
                    a.peso = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a sua altura? ");
                    a.altura = double.Parse(Console.ReadLine());
                    Console.Clear();
                    a.mensagem();
                    Console.WriteLine();
                    Console.WriteLine("Deseja gravar os dados? ");
                    Console.WriteLine("Y- Para sim ");
                    Console.WriteLine("N- Para não ");

                    escolhaUsuarioG = Console.ReadLine().ToUpper();

                    if (escolhaUsuarioG == "Y")
                    {
                        a.gravaDados();
                    }
                    else if (escolhaUsuarioG == "N")
                    {
                        Console.WriteLine("Dados não salvos!");
                    }
                }
                else if(escolhaUsuario == "L")
                {
                    a.lerDados();
                }
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("I- Verificar IMC");
                Console.WriteLine("L- Ler dados cadastrados");
                Console.WriteLine("S- Sair");
                Console.WriteLine();
                Console.WriteLine("Digite uma operação.");

                escolhaUsuario = Console.ReadLine().ToUpper();

                


            }
        }
    }
}