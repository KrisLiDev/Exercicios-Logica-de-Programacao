using System;

namespace Login_System;

public class Program
{
    public static void Main()
    {
        int Selec = 1;
        while (Selec == 1)
        {
            Console.WriteLine("Digite seu nome de usuário: ");
            string usernameDigitada = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha: ");
            string senhaDigitada = Console.ReadLine();

            string resultado = Autenticador.Autenticar(usernameDigitada, senhaDigitada);

            Console.WriteLine($"\n[SISTEMA]: {resultado}\n");

            if (resultado == "Acesso Permitido" || resultado == "Conta Bloqueada")
            {
                break;
            }

            Console.WriteLine("Deseja tentar logar novamente?");
            Console.WriteLine("1 - SIM");
            Console.WriteLine("2 - NÃO (O programa será fechado)");

            Selec = int.Parse(Console.ReadLine());
        }
    }
}