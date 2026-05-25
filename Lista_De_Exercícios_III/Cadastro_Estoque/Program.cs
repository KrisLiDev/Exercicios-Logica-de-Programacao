using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cad_Estoque;

public class Program
{
    public static void Main()
    {
        string Menu = "s";
        List<Produto> ListaProdutos = new List<Produto>

        while (Menu == "s")
        {
            Console.WriteLine("Sistema de Estoque:\nArmazem do Zé");

            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Buscar produtos");
            Console.WriteLine("4 - Fechar programa");

            int Selec = int.Parse(Console.ReadLine());

            switch (Selec)
            {
                case 1:
                    Actions.Cadastrar();
                break;

                case 2:
                    Actions.Listar();
                break;

                case 3:
                    Actions.Buscar();
                break;

                case 4:
                    Application.Exit();
                break;

                default:
                    Console.WriteLine("Opção inválida");
                break;
            }
        }
        
    }
}