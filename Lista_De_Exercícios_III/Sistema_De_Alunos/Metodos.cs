using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_De_Alunos;

public static class Metodos
{
    public static void Cadastrar()
    {
        var novoAluno = new Aluno();
        Console.WriteLine("Digite o nome do aluno: ");
        novoAluno.Nome = Console.ReadLine();
        Console.WriteLine("Digite a primeira nota: ");
        novoAluno.Nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota: ");
        novoAluno.Nota2 = float.Parse(Console.ReadLine());
        listaAlunos.Add(novoAluno);
    }

    public static float Media(float n1, float n2)
    {
        return (n1 + n2) / 2;
    }

    public static void ListarAprovados()
    {
        Console.WriteLine($"{"ALUNO",-15} | {"1º Bim",-8} | {"2º Bim",-8} | {"Média",-6}");
        Console.WriteLine(new string('-', 49));
        foreach (Aluno aluno in listaAlunos)
        {
            float media = Media(aluno.Nota1, aluno.Nota2);
            if (media >= 7)
            {
                Console.WriteLine($"{aluno.Nome,-15} | {aluno.Nota1,-8} | {aluno.Nota2,-8} | {media,-6}");
            }
        }
    }

    public static void ListarReprovados()
    {
        Console.WriteLine($"{"ALUNO",-15} | {"1º Bim",-8} | {"2º Bim",-8} | {"Média",-6}");
        Console.WriteLine(new string('-', 49));
        foreach (Aluno aluno in listaAlunos)
        {
            float media = Media(aluno.Nota1, aluno.Nota2);
            if (media < 5)
            {
                Console.WriteLine($"{aluno.Nome,-15} | {aluno.Nota1,-8} | {aluno.Nota2,-8} | {media,-6}");
            }
        }
    }

    public static void ListarRecuperação()
    {
        Console.WriteLine($"{"ALUNO",-15} | {"1º Bim",-8} | {"2º Bim",-8} | {"Média",-6}");
        Console.WriteLine(new string('-', 49));
        foreach (Alunos aluno in listaAlunos)
        {
            float media = Media(aluno.Nota1, aluno.Nota2);
            if (media >= 5 && media < 7)
            {
                Console.WriteLine($"{aluno.Nome,-15} | {aluno.Nota1,-8} | {aluno.Nota2,-8} | {media,-6}");
            }
        }
    }
}