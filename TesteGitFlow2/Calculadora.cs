using System;

namespace TesteGitFlow2
{
    public sealed class Calculadora
    {
        public Calculadora()
        {
            Console.Writeline("metodo calculadora");
        }

        public double Somar(double a, double b) {
            return a + b;
        }
        public double Subtrair(double a, double b) {
            return a - b;
        }
        public double Divisao(double a, double b) {
            return a / b;
        }
    }
}
