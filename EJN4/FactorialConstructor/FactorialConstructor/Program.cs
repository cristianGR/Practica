using System;

namespace FactorialConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial(5);
            Console.WriteLine(factorial.GetResultado());
        }
    }

    class Factorial
    {
        double Resultado;
        public Factorial(double nro)
        {
            if (nro == 1)
                Resultado = nro;
            else
                Resultado = nro * new Factorial(nro - 1).Resultado;
        }

        public double GetResultado() {
            return Resultado;
        }
    }
}
