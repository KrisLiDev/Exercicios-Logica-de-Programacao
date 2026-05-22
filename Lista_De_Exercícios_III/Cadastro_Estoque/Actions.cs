using System.Globalization;

namespace Cad_Estoque;

public static class Actions
{
    public static void Cadastrar()
    {
        string Repetir = "s";

        while (Repetir == "s")
        {
            var NovoProduto = new Produto();
            Console.WriteLine("Digite o nome do produto: ");
            NovoProduto.Nome = Console.ReadLine();
            Console.WriteLine("Digite o código do produto: ");
            NovoProduto.Code = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a quantidade em estoque: ");
            NovoProduto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto: ");
            NovoProduto.Valor = float.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

            Console.WriteLine("Exibindo dados:");
            Console.WriteLine(NovoProduto.Nome);
            Console.WriteLine(NovoProduto.Code);
            Console.WriteLine(NovoProduto.Quantidade);
            Console.WriteLine(NovoProduto.Valor);

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
                            ListaProdutos.Add(NovoProduto);
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
}