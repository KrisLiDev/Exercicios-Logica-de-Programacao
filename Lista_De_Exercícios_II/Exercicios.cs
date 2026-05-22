namespace ListaDeExerciciosII;

public static class Exercicios
{
    public static void Exercicio2()
    {
        Console.WriteLine("Enunciado: Desenvolva um código que receba um número de 1 a 12. Se estiver dentro desse intervalo, o programa deve digitar 'mês válido' do contrário ele deve exibir 'mês inválido'.");

        //Resolução
        int Num = int.Parse(Console.ReadLine());

        if (Num <= 12 && Num >= 1)
        {
            Console.WriteLine("Mês válido");
        }

        else
        {
            Console.WriteLine("Mês inválido");
        }
    }

    public static void Exercicio3()
    {
        Console.WriteLine("O município de Vida Bela está construindo um conjunto habitacional para atender as pessoas que possuem, no mínimo, um dependente  e salário entre R$ 3000,00 e R$ 5000,00. Faça um progtama que informe a pessoa se está apta ao programa habitacional.");


    }

    public static void Exercicio4()
    {
        Console.WriteLine("Escreva um program que solicite a digitação de três números e mostre o maior número digitado.");

        //Resolução
        Console.WriteLine("Digite o primeiro número: ");
        float Num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        float Num2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número: ");
        float Num3 = float.Parse(Console.ReadLine());

        if (Num1 > Num2 && Num1 > Num3)
        {
            Console.WriteLine($"O primeiro número {Num1}, é o maior digitado.");
        }

        else if (Num2 > Num1 && Num2 > Num3)
        {
            Console.WriteLine($"O segundo número {Num2}, é o maior digitado.");
        }

        else
        {
            Console.WriteLine($"O terceiro número {Num3}, é o maior digitado.");
        }
    }

    public static void Exercicio5()
    {
        Console.WriteLine("Enunciado: Desenvolva uma calculadora que faça Adição, Subtração, Multiplicação e Divisão.");

        //Resolução
        string Menu = "s";
        while (Menu == "s")
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|               <{Calculadora C#}>              |");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");

            int Selec = int.Parse(Console.ReadLine());

            if (Selec == 1)
            {
                float Num1 = float.Parse(Console.ReadLine());
                float Num2 = float.Parse(Console.ReadLine());

                float Resultado = Num1 + Num2;
                Console.WriteLine($"Resultado: {Resultado}");

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                Menu = Console.ReadLine();
            }

            else if (Selec == 2)
            {
                float Num1 = float.Parse(Console.ReadLine());
                float Num2 = float.Parse(Console.ReadLine());

                float Resultado = Num1 - Num2;
                Console.WriteLine($"Resultado: {Resultado}");

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                Menu = Console.ReadLine();
            }

            else if (Selec == 3)
            {
                float Num1 = float.Parse(Console.ReadLine());
                float Num2 = float.Parse(Console.ReadLine());

                float Resultado = Num1 * Num2;
                Console.WriteLine($"Resultado: {Resultado}");

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                Menu = Console.ReadLine();
            }

            else if (Selec == 4)
            {
                float Num1 = float.Parse(Console.ReadLine());
                float Num2 = float.Parse(Console.ReadLine());

                float Resultado = Num1 / Num2;
                Console.WriteLine($"Resultado: {Resultado}");

                Console.WriteLine("Deseja voltar ao menu? (s/n)");
                Menu = Console.ReadLine();
            }

            else if (Selec == 5)
            {
                Console.WriteLine("Fechando calculadora");
                Menu = "n";
            }

            else
            {
                Console.WriteLine("Digite uma opção válida."); 
            }

        }

    }

    public static void Exercicio6()
    {
        Console.WriteLine("Enunciado: A escola 'APRENDER' faz o pagamento dos professores por hora/aula. Faça um programa que calcule e exiba o salário do professor. Sabe-se que o valor da hora/aula segue a tabela abaixo:");
        Console.WriteLine("
        Nível | Valor da Hora/aula\n   1  | R$ 32,80\n   2  | R$ 44,15\n   3  | R$ 52,21");

        //resolução
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("|             <{Escola APRENDER}>               |");
        Console.WriteLine("-------------------------------------------------");

        int Nivel = 0;
        
        while (Nivel == 0)
        {
            Console.WriteLine("Olá professor, por favor digite seu nível: ");
            Nivel = int.Parse(Console.ReadLine());

            if (Nivel == 1)
            {
                Console.WriteLine("Digite o número de horas/aulas trabalhadas: ");
                int Tempo = int.Parse(Console.ReadLine());

                float Salario = Tempo * 32.80f;
                Console.WriteLine($"Salário final: R$ {Salario}");
            }

            else if (Nivel == 2)
            {
                Console.WriteLine("Digite o número de horas/aulas trabalhadas: ");
                int Tempo = int.Parse(Console.ReadLine());

                float Salario = Tempo * 44.15f;
                Console.WriteLine($"Salário final: R$ {Salario}");
            }

            else if (Nivel == 3)
            {
                Console.WriteLine("Digite o número de horas/aulas trabalhadas: ");
                int Tempo = int.Parse(Console.ReadLine());

                float Salario = Tempo * 52.21;
                Console.WriteLine($"Salário final: R$ {Salario}");
            }

            else
            {
                Console.WriteLine("Nível inválido. Por favor, digite um valor vállido.");
                Nivel = 0;
            }
        }
    }

    public static void Exercicio7()
    {
        Console.WriteLine("Enunciado: Faça um programa que calcule o valor do plano de saúde dos dependentes de uum funcionário.\n
        O programa deverá receber o número de dependentes, o tipo do plano desejado e mostrar o valor total.\n\n
        Tipos de Plano   | Preço por dependente\n
        1 - Total Plus   | R$ 320,00\n
        2 - Master Plus  | R$ 260,00\n
        3 - Master       | R$ 215,00\n
        4 - Single       | R$ 148,00\n\n");

        //resolução
        Console.WriteLine("Digite o número de dependentes: ");
        int Dependentes = int.Parse(Console.ReadLine());

        bool Retorno = true;

        while (Retorno == true)
        {
            Console.WriteLine("Tipos de Plano   | Preço por dependente\n
            1 - Total Plus   | R$ 320,00\n
            2 - Master Plus  | R$ 260,00\n
            3 - Master       | R$ 215,00\n
            4 - Single       | R$ 148,00\n\n
            Escolha o seu plano: ");
            int Plano = int.Parse(Console.ReadLine());

            switch (Plano)
            {
                case 1:
                    float Valor = Dependentes * 320;
                    Console.WriteLine($"Valor total: R$ {Valor}");
                    Retorno = false;
                break;

                case 2:
                    float Valor = Dependentes * 260;
                    Console.WriteLine($"Valor total: R$ {Valor}");
                    Retorno = false;
                break;

                case 3: 
                    float Valor = Dependentes * 215;
                    Console.WriteLine($"Valor total: R$ {Valor}");
                    Retorno = false;
                break;

                case 4:
                    float Valor = Dependentes * 148;
                    Console.WriteLine($"Valor total: R$ {Valor}");
                    Retorno = false;
                break;

                default:
                    Console.WriteLine("Plano inválido");
                    Retorno = true;
                break;
            }
        }

    }

    public static void Exercicio8()
    {
        Console.WriteLine("Enunciado: Escreva um programa que leia um valor inteiro e informe se ele é par ou impar.\n
        *Utilize o operador % (resto da divisão) ex: resto = numero % 2");

        //resolução
        Console.WriteLine("Digite um número: ");
        int Num = int.Parse(Console.ReadLine());
        int Resto = Num % 2;

        if (Resto == 0)
        {
            Console.WriteLine($"O número {Num} é par");
        }

        else
        {
            Console.WriteLine($"O número {Num} é impar");
        }
    }

    public static void Exercicio9()
    {
        Console.WriteLine("Enunciado: A loja SeuLar lançou uma promoção com drscontos que vão de 27% a 48%. A loja elaborou uma tabela de descontos por tipo de produto, sendo: \n
        'A' - Geladeira - 35%\n
        'B' - Maquina de lavar - 27% \n
        'C' - Televisor - 48% \n
        Faça um programa que solicite a digitação do preço e do tipo de produto, calcule o valor a ser pago e apresente o resultado na tela.")

        //resolução
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("|               <{Loja SeuLar}>                 |");
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("\nA - Geladeira\nB - Máquina de Lavar\nC - Televisor");
        Console.WriteLine("Digite o preço do produto: ")
        float Valor = float.Parse(Console.ReadLine())
        Console.WriteLine("Digite o tipo de produto: ");
        string ProdTipo = Console.ReadLine().ToUpper();

        if (ProdTipo == "A")
        {
            Valor = Valor - (Valor * 0.35);
            Console.WriteLine($"Preço final: R${Valor}");
        }

        else if (ProdTipo == "B")
        {
            Valor = Valor - (Valor * 0.27);
            Console.WriteLine($"Preço final: R${Valor}");   
        }

        else if (ProdTipo == "C")
        {
            Valor = Valor - (Valor * 0.48);
            Console.WriteLine($"Preço final: R${Valor}");   
        }

        else
        {
            Console.WriteLine($"Produto fora das categorias acima.\n
            Valor a pagar: R${Valor}");
        }

    }

    public static void Exercicio10()
    {
        Console.WriteLine("Enunciado: Faça um programa que leia o nome, o sexo, a altura e a idade de uma pessoa\n
        e calcule o seu peso ideal. O cálculo deve ser realizado conforme os parâmetros definidos na tabela abaixo:\n");

        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("| Sexo | Altura    | Idade     | Peso Ideal             |");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("|      |           | <= 40     | (72.7 * h) - 58        |");
        Console.WriteLine("|      | > 1.70    |-----------|------------------------|");
        Console.WriteLine("|      |           | > 40      | (72.7 * h) - 45        |");
        Console.WriteLine("|  M   |-----------|-----------|------------------------|");
        Console.WriteLine("|      |           | <= 40     | (72.7 * h) - 50        |");
        Console.WriteLine("|      | <= 1.70   |-----------|------------------------|");
        Console.WriteLine("|      |           | > 40      | (72.7 * h) - 58        |");
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("|      | > 1.50    |    ---    | (62.1 * h) - 44.7      |");
        Console.WriteLine("|      |-----------|-----------|------------------------|");
        Console.WriteLine("|  F   |           | >= 35     | (62.1 * h) - 45        |");
        Console.WriteLine("|      | <= 1.50   |-----------|------------------------|");
        Console.WriteLine("|      |           | < 35      | (62.1 * h) - 49        |");
        Console.WriteLine("---------------------------------------------------------\n");

        //resolução
        Console.WriteLine("Digite seu nome: ");
        string Nome = Console.ReadLine();
        Console.WriteLine("Digite seu sexo (M/F): ");
        string Sexo = Console.ReadLine().ToUpper();
        Console.WriteLine("Digite sua altura:\n
        ATENÇÃO: Use o ponto ao invés da virgula.\n
        Ex: 1,75 -> 1.75");
        float Altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua idade: ");
        int Idade = int.Parse(Console.ReadLine());

        if (Sexo == "M" && Altura > 1.70 && Idade <= 40)
        {
            float PesoIdeal = (72.7*Altura) - 58;
            Console.WriteLine($"{Nome} seu peso ideal é {PesoIdeal}Kg");
        }

        else if (Sexo == "M" && Altura > 1.70 && Idade > 40)
        {
            float PesoIdeal = (72.7*Altura) - 45;
            Console.WriteLine($"{Nome} seu peso ideal é {PesoIdeal}Kg");
        }

        else if (Sexo == "M" && Altura <= 1.70 && Idade <= 40)
        {
            float PesoIdeal = (72.7*Altura) - 50;
            Console.WriteLine($"{Nome} seu peso ideal é {PesoIdeal}Kg");
        }

        else if (Sexo == "M" && Altura <= 1.70 && Idade > 40)
        {
            float PesoIdeal == (72.7*Altura) - 58;
            Console.WriteLine($"{Nome} seu peso ideal é {PesoIdeal}Kg");
        }

        else if (Sexo == "F" && Altura > 1.50)
        {
            float PesoIdeal = (62.1 * Altura) - 44.7;
            Console.WriteLine($"{Nome} seu peso ideal é {PesoIdeal}Kg");
        }

        else if (Sexo == "F" && Altura <= 1.50 && Idade >= 35)
        {
            float PesoIdeal = (62.1 * Altura) - 45;
            Console.WriteLine($"{Nome} seu peso ideal é {PesoIdeal}Kg");
        }

        else if (Sexo == "F" && Altura <= 1.50 && Idade < 35)
        {
            float PesoIdeal = (62.1 * Altura) - 49;
            Console.WriteLine($"{Nome} seu peso ideal é {PesoIdeal}Kg");
        }
    }

    public static void Exercicio11()
    {
        Console.WriteLine("Enunciado: Faça um programa para calcular o valor de uma conta de luz.\n
        O programa deverá receber a quantidade de Kwh consumidos e o tipo de cliente (1, 2 ou 3), calcular e exibir o valor da conta. \n
        Sabe-se que o valor do Kwh segue a tabela abaixo:\n");

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("| Tipo de Cliente         | Valor do Kwh   |");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("| 1 (Residência)          | 0,60           |");
        Console.WriteLine("| 2 (Comércio)            | 0,48           |");
        Console.WriteLine("| 3 (Indústria)           | 1,29           |");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Fórmula: Conta = Qtd_Kwh * Valor_do_Kwh\n");

        //resolução
        Console.WriteLine("Bem vindo ao sistema CEB. Para calcular sua conta, favor digitar a quantidade de Kwh consumidos: ");
        float Qtd_Kwh = float.Parse(Console.ReadLine());
        bool Retorno = true;

        while (Retorno == true)
        {
            Console.WriteLine("Digite seu tipo de cliente:\n
            1 - Residencial\n
            2 - Comercial\n
            3 - Industrial");
            int Tipo = int.Parse(Console.ReadLine());

            switch (Tipo)
            {
                case 1:
                    float Conta = Qtd_Kwh * 0.6;
                    Console.WriteLine($"O valor da sua conta será de: R$ {Conta}");
                    Retorno = false;
                break;

                case 2:
                    float Conta = Qtd_Kwh * 0.48;
                    Console.WriteLine($"O valor da sua conta será de: R$ {Conta}");
                    Retorno = false;
                break;

                case 3:
                    float Conta = Qtd_Kwh * 0.6;
                    Console.WriteLine($"O valor da sua conta será de: R$ {Conta}");
                    Retorno = false;
                break;

                default:
                    Console.WriteLine("Tipo inválido. Por favor digite novamente.");
                    Retorno = true;
                break;
                    
            }
        }
    }
}