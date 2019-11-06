using System;

public class Pessoa
{
    public DateTime dataNascimento;
    public string nome;
    public string rg;
    public string email;
    public string password;

    public static Pessoa Login(string email, string password) {
        return LoginPessoa(email, password);
    }

    public static Pessoa LoginPessoa(string email, string password){
        if( email == "john" && password == "doe")
        Pessoa p = new Pessoa();
        return p;
    }
}
