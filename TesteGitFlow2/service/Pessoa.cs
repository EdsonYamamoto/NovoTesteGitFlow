using System;

public class ServicePessoa
{

    public static Pessoa Login(string email, string password)
    {
        Pessoa tentativaLogin = TesteLoginPessoa(email, password);
        if (tentativaLogin == null)
            return null;
        else
            return tentativaLogin;
    }

    public static Pessoa TesteLoginPessoa(string email, string password)
    {
        if (email == "john" && password == "doe")
            Pessoa p = new Pessoa();
        return p;
    }
}
