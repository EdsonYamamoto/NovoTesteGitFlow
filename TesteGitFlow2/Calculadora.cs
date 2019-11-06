using System;

namespace TesteGitFlow2
{
    public sealed class Singleton<T> where T : class, new()
    {
        private static T instance;

        public static T Instance()
        {
            lock (typeof(T))
                if (instance == null) instance = new T();

            return instance;
        }
    }

    public class Calculadora
    {
        public double Somar(double a, double b) {
            return a + b;
        }
        public double Subtrair(double a, double b) {
            return a - b;
        }
        public double Divisao(double a, double b) {
            return a / b;
        }
        public double RaizQuadrada(double a)
        {
            return Math.Sqrt(a);
        }
    }
}
