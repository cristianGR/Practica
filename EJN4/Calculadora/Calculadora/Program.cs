using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Calculadora
    {
        float Resultado = 0;

        Calculadora()
        {
            Resultado = 0;
        }

        public Double Calcular(float valorA, float valorB, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    suma(valorA, valorB);
                    break;
                case "-":
                    resta(valorA, valorB);
                    break;
                case "*":
                    multiplicacion(valorA, valorB);
                    break;
                case "/":
                    division(valorA, valorB);
                    break;
            }

            return Resultado;
        }

        private void division(float valorA, float valorB)
        {
            try
            {
                Resultado = valorA / valorB;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero");
            }

        }

        private void multiplicacion(float valorA, float valorB)
        {
            Resultado = valorA * valorB;
        }

        private void resta(float valorA, float valorB)
        {
            Resultado = valorA - valorB;
        }

        private void suma(float valorA, float valorB)
        {
            Resultado = valorA + valorB;
        }

        public float GetResultado()
        {
            return Resultado;
        }
    }
}
