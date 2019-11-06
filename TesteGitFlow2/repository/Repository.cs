using System;

public class Repository
{
    public static T Buscar<T>()
    {

        return (T)Convert.ChangeType(value, typeof(T));
    }
}
