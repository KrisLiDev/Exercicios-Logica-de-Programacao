using System;

namespace Login_System;

public static class Autenticador
{
    public static string Autenticar(string usernameDigitada, string senhaDigitada)
    {
        if (User.bloqueio == true)
        {
            return "Conta Bloqueada";
        }

        else
        {
            if (usernameDigitada == User.username && senhaDigitada == User.password)
            {
                return "Acesso Permitido";
            }

            else
            {
                User.tentativasFalhas++;
                if (User.tentativasFalhas >= 3)
                {
                    User.bloqueio = true;
                }
                return "Acesso Negado";
            }
        }
    }
}