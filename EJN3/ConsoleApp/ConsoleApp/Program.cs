using System;
using System.Diagnostics;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] garage = new Auto[10];

            Auto electrico = new Auto("Electrico 1");
            electrico.Acelerar();
 
        }
    }

    class Auto
    {
        string Nombre;
        int Velocidad;

        public Auto(string nombre){
            Nombre = nombre;
            Velocidad = 0;
        }


        public void Acelerar(){
            int MaxVel = 100;
            Console.WriteLine("Velocidad: " + Velocidad);
                Velocidad++;
            if (Velocidad == MaxVel) return;
                Acelerar();
        }

    }
}
