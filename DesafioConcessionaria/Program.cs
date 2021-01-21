using DesafioConcessionaria;
using System;
using System.Collections.Generic;


namespace DesafioConcessionaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int opDmarcaEscolhida = 0;
            int opDmodeloEscolhido = 0;
            string marcaEscolhida = "";
            string modeloEscolhido = "";

            Console.WriteLine("Bem vindo a Concessionaria --** PRECIOSO **-- ");
            Console.WriteLine(" ");
            Console.WriteLine("Por gentileza informe seu nome ");
            Cliente Cli = new Cliente();
            Cli.Nome = Console.ReadLine();

            Console.WriteLine("Bem vindo Precioso " + Cli.Nome);
            Console.WriteLine(" ");
            Console.WriteLine("Por favor informe seu saldo");
            Cli.Saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Seu saldo é de " + Cli.Saldo + " vamos comprar uns carros ? ");
            Console.WriteLine(" ");
            Console.WriteLine("Precioso, veja em nossa lista as variedades de carros e escolha o seu ");

            Console.WriteLine("digite o numero da marca do carro que deseja ");
            Console.WriteLine("1 - Ford");
            Console.WriteLine("2 - Fiat");
            Console.WriteLine("3 - Jeep");
            Console.WriteLine("4 - volks");
            Console.WriteLine("5 - Renault");
            Console.WriteLine("6 - Toyota");
            opDmarcaEscolhida = Convert.ToInt32(Console.ReadLine());

            if (opDmarcaEscolhida == 1)
            {
                marcaEscolhida = "Ford";
            }
            else if (opDmarcaEscolhida == 2)
            {
                marcaEscolhida = "Fiat";
            }
            else if (opDmarcaEscolhida == 3)
            {
                marcaEscolhida = "Jeep";
            }
            else if (opDmarcaEscolhida == 4)
            {
                marcaEscolhida = "Volks";
            }
            else if (opDmarcaEscolhida == 5)
            {
                marcaEscolhida = "Renault";
            }
            else if (opDmarcaEscolhida == 6)
            {
                marcaEscolhida = "Toyota";
            }
            else
            {
                Console.WriteLine("Opção invalida ");
                return;
            }

            Console.WriteLine("Agora digite o numero do modelo escolhido ");
            Console.WriteLine("1 - Ranger");
            Console.WriteLine("2 - Uno");
            Console.WriteLine("3 - Renegade");
            Console.WriteLine("4 - Voyagen");
            Console.WriteLine("5 - Clio");
            Console.WriteLine("6 - Corolla");
            opDmodeloEscolhido = Convert.ToInt32(Console.ReadLine());


            if (opDmodeloEscolhido == 1)
            {
                modeloEscolhido = "Ranger";
            }
            else if (opDmodeloEscolhido == 2)
            {
                modeloEscolhido = "Uno";
            }
            else if (opDmodeloEscolhido == 3)
            {
                modeloEscolhido = "Renegade";
            }
            else if (opDmodeloEscolhido == 4)
            {
                modeloEscolhido = "Voyagen";
            }
            else if (opDmodeloEscolhido == 5)
            {
                modeloEscolhido = "Clio";
            }
            else if (opDmodeloEscolhido == 6)
            {
                modeloEscolhido = "Corolla";
            }
            else
            {
                Console.WriteLine("Opção invalida ");
                return;
            }

            Console.WriteLine("Precioso, sua marca escolhida foi " + marcaEscolhida + " e o modelo que vc quer é " + modeloEscolhido);








            Console.ReadLine();
        }
    }
}
