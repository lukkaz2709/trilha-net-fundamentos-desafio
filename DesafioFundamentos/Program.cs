using System;
using DesafioFundamentos.Models;

namespace DesafioFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuração de preços (exemplo: 5 reais fixo + 2 por hora)
            decimal precoInicial = 5;
            decimal precoPorHora = 2;

            Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        estacionamento.AdicionarVeiculo();
                        break;

                    case "2":
                        estacionamento.RemoverVeiculo();
                        break;

                    case "3":
                        estacionamento.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
            }

            Console.WriteLine("O programa se encerrou.");
        }
    }
}

