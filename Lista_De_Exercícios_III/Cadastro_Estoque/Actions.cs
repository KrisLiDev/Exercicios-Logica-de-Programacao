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
            novoProduto.Nome = Console.ReadLine();
            Console.WriteLine("Digite o código do produto: ");
            novoProduto.Code = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a quantidade em estoque: ");
            novoProduto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: ");
            novoProduto.Valor = float.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

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
    }

    public static void Listar()
    {
        Console.WriteLine($"{"NOME",-15} | {"CÓDIGO",-8} | {"QTD",-6} | {"PREÇO",-10} | {"TOTAL",-10}");
        Console.WriteLine(new string('-', 59));
        foreach (Produto Produto in ListaProdutos)
        {
            Console.WriteLine($"{Produto.Nome,-15} | {Produto.Code,-8} | {Produto.Quantidade,-6} | {"R$ " + Produto.Valor.ToString("F2"),-10} | {"R$ " + (Produto.Valor * Produto.Quantidade).ToString("F2"),-10}");
        }
    }
}