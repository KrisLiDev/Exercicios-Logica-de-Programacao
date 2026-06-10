using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_V2;

public static class Metodos
{
    public static void Somar()
    {
        Console.WriteLine("Digite o primeiro número: ");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float Num2 = float.Parse(Console.ReadLine());

        float Resultado = Num1 + Num2;
        Console.WriteLine($"Resultado: {Resultado}");
    }

    public static void Subtrair()
    {
        Console.WriteLine("Digite o primeiro número: ");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float Num2 = float.Parse(Console.ReadLine());

        float Resultado = Num1 - Num2;
        Console.WriteLine($"Resultado: {Resultado}");
    }

    public static void Multiplicar()
    {
        Console.WriteLine("Digite o primeiro número: ");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float Num2 = float.Parse(Console.ReadLine());

        float Resultado = Num1 * Num2;
        Console.WriteLine($"Resultado: {Resultado}");
    }

    public static void Dividir()
    {
        Console.WriteLine("Digite o primeiro número: ");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float Num2 = float.Parse(Console.ReadLine());
        while (Num2 == 0)
        {
            Console.WriteLine("Indivisivel por 0");
            Console.WriteLine("Digite o segundo número: ");
            Num2 = float.Parse(Console.ReadLine());
        }

        float Resultado = Num1 / Num2;
        Console.WriteLine($"Resultado: {Resultado}");
    }
}