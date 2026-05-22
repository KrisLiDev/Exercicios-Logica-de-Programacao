using System;

namespace ListaDeExerciciosII;

public class Program
{
    public static void Main()
    {
        string RetornoMenu = "s";
        
        while(RetornoMenu == "s")
        {
            Console.WriteLine("Lista de Exercícios Python em C#");
            Console.WriteLine("2 - Validação de Mês");
            Console.WriteLine("3 - Município Vida Bela");
            Console.WriteLine("4 - Comparador de três números");
            Console.WriteLine("5 - Calculadora");
            Console.WriteLine("6 - Cálculo salárial escola APRENDER");
            Console.WriteLine("7 - Custo Plano de Saúde");
            Console.WriteLine("8 - Paridade em números");
            Console.WriteLine("9 - Promoção na loja SeuLar");
            Console.WriteLine("10 - Cálculador de peso ideal");
            Console.WriteLine("11 - Cálculo de energia elétrica\n");

            Console.WriteLine("Escolha a questão para executar: ");
            int Selec = int.Parse(Console.ReadLine());

            Console.WriteLine("ATENÇÃO: Caso precise de virgula use ponto no lugar\nExemplo(1.50)");

            switch (Selec)
            {
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

                case 8:
                    Exercicios.Exercicio8();
                break;

                case 9:
                    Exercicios.Exercicio9();
                break;

                case 10:
                    Exercicios.Exercicio10();
                break;

                case 11:
                    Exercicios.Exercicio11();
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