using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_Telefonica;

public static class Function
{
    public static void Cadastrar()
    {
        var novoContato = new Contato();
        Console.WriteLine("Digite o nome do novo contato: ");
        novoContato.Nome = Console.ReadLine();
        Console.WriteLine($"Digite o telefone de {novoContato.Nome}");
        novoContato.Telefone = Console.ReadLine();
        listaContatos.Add( novoContato );
    }

    public static void Listar()
    {
        Console.WriteLine($"{"NOME",-15} | {"TELEFONE",-15}");
        foreach (Contato contato in listaContatos)
        {
            Console.WriteLine($"{contato.Nome,-15} | {contato.Telefone,-15}");
        }
    }

    public static List<Contato> Buscar()
    {
        List<Contatos> contatosEncontrados = new List<Contato>();

        Console.WriteLine("Digite o nome do contato desejado: ");
        string nomeBuscado = Console.ReadLine();

        foreach (Contato contato in listaContatos)
        {
            if (contato.Nome.ToLower() == nomeBuscado.ToLower())
            {
                contatosEncontrados.Add(contato);
            }
        }

        if (contatosEncontrados.Count == 0)
        {
            Console.WriteLine("Nenhum contato encontrado.");
            return contatosEncontrados;
        }

        Console.WriteLine("\n--- CONTATOS ENCONTRADOS ---");
        for (int i = 0; i < contatosEncontrados.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {contatosEncontrados[i].Nome,-15} | {contatosEncontrados[i].Telefone,-15}");
        }

        return contatosEncontrados;
    }

    public static void Remover()
    {
        List<Contato> encontrados = Buscar();

        if (encontrados.Count == 0)
        {
            return;
        }

        Console.WriteLine("\nDigite o contato que deseja REMOVER: ");
        int.TryParse(Console.ReadLine(), out int escolha);
        int indiceSelecionado = escolha - 1;

        if (indiceSelecionado >= 0 && indiceSelecionado < encontrados.Count)
        {
            Contato alvo = encontrados[indiceSelecionado];
            listaContatos.Remove(alvo);
            Console.WriteLine($"\nContato {alvo.Nome} removido com sucesso!");
        }

        else
        {
            Console.WriteLine("Opção inválida. Operação cancelada.");
        }
    }
}