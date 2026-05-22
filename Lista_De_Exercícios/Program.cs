// Pra dar uma melhorada no meu aprendizado, eu decidi pegar os exercícios para python da faculdade e fazer em .NET
// Como eu já tenho eles feitos em python, eu básicamente vou traduzir. Vou deixar os enunciados (não sei se serão comentários)
// É uma lista de sete exercícios e vou colocar tudo em um programa só para seleção de estilo menu

// Olá, caso seja um colega da faculdade e por algum motivo esteja tendo contato com esse código, é apenas um estudo que fiz para melhorar minhas habilidade em C#. Enfim se sinta a vontade para estudar um pouco.

using System;

namespace ListaDeExercicios;

public class Program
{
    public static void Main()
    {
        string RetornoMenu = "s";
        
        while(RetornoMenu == "s")
        {
            Console.WriteLine("Lista de Exercícios Python em C#");
            Console.WriteLine("1 - Volume de Caixa");
            Console.WriteLine("2 - Gasto de Combustível");
            Console.WriteLine("3 - Consumo Médio de Automóvel");
            Console.WriteLine("4 - Porcentagem de Eleitores");
            Console.WriteLine("5 - Cálculo Móveis Planejados");
            Console.WriteLine("6 - Custo de Carro");
            Console.WriteLine("7 - Orçamento de Eventos\n");

            Console.WriteLine("Escolha a questão para executar: ");
            int Selec = int.Parse(Console.ReadLine());

            Console.WriteLine("ATENÇÃO: Caso precise de virgula use ponto no lugar\nExemplo(1.50)");

            switch (Selec)
            {
                case 1:
                    Exercicios.Exercicio1();
                break;
            
                case 2:
                    Exercicios.Exercicio2();
                break;

                case 3:
                    Exercicios.Exercicio3();
                break;

                case 4:
                    Exercicios.Exercicio4();
                break;

                case 5:
                    Exercicios.Exercicio5();
                break;

                case 6:
                    Exercicios.Exercicio6();
                break;

                case 7:
                    Exercicios.Exercicio7();
                break;

                default:
                    Console.WriteLine("Opção inválida");
                break;
            }

            Console.WriteLine("Deseja voltar ao menu? (s/n)");
            RetornoMenu = Console.ReadLine();
        }
    }
}