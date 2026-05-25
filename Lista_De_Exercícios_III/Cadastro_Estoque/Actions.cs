using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cad_Estoque;

public static class Actions
{
    public static void Cadastrar()
    {
        string Repetir = "s";

        while (Repetir == "s")
        {
            var novoProduto = new Produto();
            Console.WriteLine("Digite o nome do produto: ");
            novoProduto.Nome = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o código do produto: ");
            novoProduto.Code = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a quantidade em estoque: ");
            novoProduto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: ");
            novoProduto.Valor = float.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
            while (novoProduto.Valor <= 0)
            {
                Console.WriteLine("Valor inválido.\nDigite o preço do produto: ");
                novoProduto.Valor = float.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Exibindo dados:");
            Console.WriteLine(novoProduto.Nome);
            Console.WriteLine(novoProduto.Code);
            Console.WriteLine(novoProduto.Quantidade);
            Console.WriteLine(novoProduto.Valor);

            Console.WriteLine("Os dados estão corretos?\n(s/n)");
            string Correto = Console.ReadLine().ToLower();
            switch (Correto)
            {
                case "s":
                    string TriggerAddEstoque = "s";
                    while (TriggerAddEstoque == "s")
                    {
                        Console.WriteLine("Adicionar ao estoque?\n(s/n)");
                        string Adicionar = Console.ReadLine().ToLower();
                        if (Adicionar == "s")
                        {
                            ListaProdutos.Add(novoProduto);
                            Console.WriteLine("Produto adicionado com sucesso.");
                            TriggerAddEstoque = "n";
                        }

                        else if (Adicionar == "n")
                        {
                            Console.WriteLine("Produto não adicionado.");
                            TriggerAddEstoque = "n";
                        }

                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }

                    }
                break;

                case "n":
                    string Redigitar = "s";
                    while (Redigitar == "s")
                    {
                        Console.WriteLine("Deseja digitá-los novamente?\n(s/n)");
                        string RepetirTrigger = Console.ReadLine().ToLower();

                        if (RepetirTrigger == "s")
                        {
                            Repetir = "s";
                            Redigitar = "n";
                        }

                        else if (RepetirTrigger == "n")
                        {
                            Console.WriteLine("Retornando ao menu.");
                            Repetir = "n";
                            Redigitar = "n";
                        }

                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                    }
                break;    
            }
        }
        Console.WriteLine("\nAperte Enter para retornar ao menu.");
        Console.ReadLine();
    }

    public static void Listar()
    {
        Console.WriteLine($"{"NOME",-15} | {"CÓDIGO",-8} | {"QTD",-6} | {"PREÇO",-10} | {"TOTAL",-10}");
        Console.WriteLine(new string('-', 59));
        foreach (Produto Produto in ListaProdutos)
        {
            Console.WriteLine($"{Produto.Nome,-15} | {Produto.Code,-8} | {Produto.Quantidade,-6} | {"R$ " + Produto.Valor.ToString("F2"),-10} | {"R$ " + (Produto.Valor * Produto.Quantidade).ToString("F2"),-10}");
        }

        Console.WriteLine("Aperte Enter para retornar ao menu.");
        Console.ReadLine();
    }

    public static void Pesquisar()
    {
        List<Produto> ProdutoSearch = new List<Produto>();
        string searchRefRepeat = "s";

        while (searchRefRepeat == "s")
        {
            Console.WriteLine("Qual será a referência de Busca?\n1 - Código\n2 - Nome");
            string searchRef = Console.ReadLine();
            
            if (searchRef == "1")
            {
                Console.WriteLine("Digite o produto que está buscando: ");
                string Pesquisa = Console.ReadLine().ToLower();
                foreach (Produto Produto in ListaProdutos)
                {
                    if (Produto.Code == Pesquisa)
                    {
                        ProdutoSearch.Add(Produto);
                    }
                }
                searchRefRepeat = "n";

            }

            else if (searchRef == "2")
            {
                Console.WriteLine("Digite o produto que está buscando: ");
                string Pesquisa = Console.ReadLine().ToLower();
                foreach (Produto Produto in ListaProdutos)
                {
                    if (Produto.Nome.ToLower().Contains(Pesquisa))
                    {
                        ProdutoSearch.Add(Produto);
                    }
                }
                searchRefRepeat = "n";
            }

            else
            {
                Console.WriteLine("Entrada inválida.");
                searchRefRepeat = "s";
            }
        }
        
        
        if (ProdutoSearch.Count == 0)
        {
            Console.WriteLine("Nenhum produto encontrado.");
        }

        else
        {
            Console.WriteLine($"{"NOME",-15} | {"CÓDIGO",-8} | {"QTD",-6} | {"PREÇO",-10} | {"TOTAL",-10}");
            Console.WriteLine(new string('-', 59));
            foreach (Produto Produto in ProdutoSearch)
            {
                Console.WriteLine($"{Produto.Nome,-15} | {Produto.Code,-8} | {Produto.Quantidade,-6} | {"R$ " + Produto.Valor.ToString("F2"),-10} | {"R$ " + (Produto.Valor * Produto.Quantidade).ToString("F2"),-10}");
            }
        }

        Console.WriteLine("\nAperte Enter para retornar ao menu.");
        Console.ReadLine();
    }
}