namespace ListaDeExercicios;

public static class Exercicios
{
    public static void Exercicio1()
    {
        Console.WriteLine("Enunciado: Faça um algoritmo que calcule o volume de uma caixa. \nUtilize para o cálculo a formula Volume = Comprimento * Largura * Altura\n");

        //Resolução
        Console.WriteLine("Digite em metros o comprimento: ");
        double Comp = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite em metros a largura: ");
        double Larg = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite em metros a altura: ");
        double Alt = double.Parse(Console.ReadLine());

        double Volume = Comp*Larg*Alt;
        Console.WriteLine($"Sua caixa possui {Volume}m³");
    }

    public static void Exercicio2()
    {
        Console.WriteLine("Enunciado: Faça um algoritmo que permita calcular a quantidade de litros de combustível gastos numa viagem de carro. \nSabe-se que a fórmula para o cálculo é:");
        Console.WriteLine("Gasto = distância/consumo \nSendo o consumo a quantidade de quilômetros que podem ser percorridos com um litro de combustivel.\n");

        //Resolução
        Console.WriteLine("Digite quantos quilômetros são percorridos com um litro de combustível: ");
        double Consumo = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite em quilômetros a distância percorrida");
        double Dist = double.Parse(Console.ReadLine());

        double Gasto = Dist/Consumo;
        Console.WriteLine($"Seu gasto foi de {Gasto} Litros de combustível");
    }

    public static void Exercicio3()
    {
        Console.WriteLine("Enunciado: Escreva um programa oara determinar o consumo médio deu um automóvel, sendo fornecida a distância total percorrida e o total de combustível gasto.");

        //Resolução
        Console.WriteLine("Digite a distância percorrida em km: ");
        double KmRodado = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de combustível gasto em litro: ");
        double LtGasto = double.Parse(Console.ReadLine());

        double MediaConsumo = KmRodado/LtGasto;
        Console.WriteLine($"Sua média de consumo é de {MediaConsumo}Km/Litro");
    }

    public static void Exercicio4()
    {
        Console.WriteLine("Enunciado: Escreva um programa para ler o numero total de eleitores de um município, o número de votos brancos, de votos nulos e votos válidos. \nAo final, mostre o percentua que cada tipo de voto representa em relação ao total de eleitores.");

        //Resolução
        Console.WriteLine("Digite o número total de eleitores: ");
        int TotalEleitores = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de votos nulos: ");
        int Nulos = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de votos brancos: ");
        int Brancos = int.Parse(Console.ReadLine());
        int Validos = TotalEleitores - (Nulos + Brancos);

        double PctBrancos = (Brancos*100)/TotalEleitores;
        double PctNulos = (Nulos*100)/TotalEleitores;
        double PctValidos = (Validos*100)/TotalEleitores;

        Console.WriteLine($"Nulos = {PctNulos}% \nBrancos = {PctBrancos}% \nValidos = {PctValidos}%");
    }

    public static void Exercicio5()
    {
        Console.WriteLine("Enunciado: A loja de móveis planejados, especialista em armários embutidos para quartosn faz o orçamento conforme o tamanho do armário e o preço do metro quadrado.");
        Console.WriteLine("Faça um algoritmo que receba as medidas do armário, base e altura, o preço do metro quadrado do modelo escolhido pelo cliente e exiba o valor a ser pago.");
        Console.WriteLine("Utiize a fórmula: Preço = (Base * Altura) * Metro_Quadrado");

        //Resolução
        Console.WriteLine("Digite em metros a base: ");
        double Base = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite em metros a altura: ");
        double Altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o preço do metro quadrado: ");
        double Metro = double.Parse(Console.ReadLine());

        double Valorfinal = (Base*Altura)*Metro;
        Console.WriteLine($"O valor final será R$ {Valorfinal}");
    }

    public static void Exercicio6()
    {
        Console.WriteLine("Enunciado: O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do distribuidor (28%) e dos impostos aplicados do distribuidor (45%). \nLeia o custo de fábrica e escreva o custo final.");

        //Resolução
        Console.WriteLine("Digite o valor de fábrica do veículo.");
        double CustoFab = double.Parse(Console.ReadLine());

        double DistPct = (28*100)/CustoFab;
        double Imposto = (45*100)/(CustoFab+DistPct);
        double ValorFinal = CustoFab + DistPct + Imposto;

        Console.WriteLine($"O valor de fábrica é: R$ {Math.Round(CustoFab,2)}\n O valor final é: R${Math.Round(ValorFinal,2)}");
    }

    public static void Exercicio7()
    {
        Console.WriteLine("Enunciado: Faça um programa que elabore o orçamento básico de um evento. O organizador informará o número de convidados, o custo do buffet por pessoa, o valor do aluguel do salão\n e o gasto fixo da decoração. O algoritmo deve calcular o custo total do evento, que é a soma do aluguel, da decoração e do resultado da multiplicação do número de convidados pelo custo do buffet. \nPor fim, calcule o custo médio por convidado dividindo o custo total pelo número de pessoas.");

        //Resolução
        Console.WriteLine("Digite o número de convidados: ");
        int Convidados = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do buffet: ");
        double Buffet = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do aluguel: ");
        double Aluguel = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da decoração: ");
        double Deco = double.Parse(Console.ReadLine());

        double Total = Aluguel + Deco + (Buffet * Convidados);
        double Media = Total/Convidados;

        Console.WriteLine($"O custo total é R$ {Math.Round(Total,2)}\nCom uma média de R$ {Math.Round(Media,2)} por pessoa");
    }
}