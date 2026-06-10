using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_V2;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("|               <{Calculadora C#}>              |");
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n");

        int Selec = int.Parse(Console.ReadLine());

        switch (Selec)
        {
            case 1:
            Metodos.Somar();
            break;

            case 2:
            Metodos.Subtrair();
            break;

            case 3:
            Metodos.Multiplicar();
            break;

            case 4:
            Metodos.Dividir();
            break;

            default:
            Console.WriteLine("Seleção inválida.");
            break;
        }
    }
}