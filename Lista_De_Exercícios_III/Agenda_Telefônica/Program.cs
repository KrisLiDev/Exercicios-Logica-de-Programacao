using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_Telefonica;

public class Program
{
    public static void Main()
    {
        List<Contato> listaContatos = new List<Contato>();

        bool rodando = true;

        while (rodando)
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("        LISTA TELEFÔNICA         ");
            Console.WriteLine("=================================");
            Console.WriteLine("1 - Cadastrar Contato");
            Console.WriteLine("2 - Listar Contatos");
            Console.WriteLine("3 - Buscar Contatos");
            Console.WriteLine("4 - Remover Contato");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("=================================");
            Console.Write("Escolha uma opção: ");

            int.TryParse(Console.ReadLine(), out int opcao);

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Function.Cadastrar();
                    break;

                case 2:
                    Function.Listar();
                    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;

                case 3:
                    Function.Buscar();
                    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;

                case 4:
                    Function.Remover();
                    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Encerrando o sistema. Até mais!");
                    rodando = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida! Aperte qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}