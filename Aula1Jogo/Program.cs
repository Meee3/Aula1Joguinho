using System;

namespace Aula1Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, contadorTentativas = 0;
            bool resultado;
            bool entrouNoLabirinto = true;
            int numeroAleatorio = new Random().Next(1, 5);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Seja bem vindo ao mundo não animado! opa," +
                " ao mundo totalmente animado!!!  ");
            Console.WriteLine("Serão três perguntas, e você terá que escolher um número aleatório");
            Console.WriteLine("Caso seus números sejam os ideais, sairá do labirinto que estas!!!");

            Console.WriteLine();

            while (entrouNoLabirinto)
            {
 
            Console.WriteLine("Pois bem, digite um número: ");
            num1 = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("O último é: ");
            num3 = int.Parse(Console.ReadLine());

            resultado = (num1 * num2 + num3) % 2 == 0;

             Console.WriteLine("Só andou em círculos");
                Console.WriteLine("Tente Novamente");
                Console.WriteLine();
                contadorTentativas++;
                
              if(resultado == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hãããããããããããã, como assim..... tu achou a saída....");
                    entrouNoLabirinto = false;
                }


            }

            Console.WriteLine();
            Console.WriteLine("Narrador: bom eu contei estas tentativas: "+ contadorTentativas + numeroAleatorio);
            Console.WriteLine();
            Console.WriteLine($"(Se liga as suas tentativas reais foram: {contadorTentativas})");


        }
    }
}
