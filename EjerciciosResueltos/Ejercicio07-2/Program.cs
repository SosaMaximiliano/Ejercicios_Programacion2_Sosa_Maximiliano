using System;
using BibliotecaDeClases;

namespace Ejercicio07_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double  bbase,
                    altura;

            string numeroIngresado;

            Console.WriteLine("Ingrese base:");
            numeroIngresado = Console.ReadLine();
            if (double.TryParse(numeroIngresado, out bbase))
            {
                Console.WriteLine("Ingrese base:");
                numeroIngresado = Console.ReadLine();
                if (double.TryParse(numeroIngresado, out altura))
                {
                    Console.WriteLine(Calculadora.CalcularHipotenusa(bbase, altura));
                }
            }
        }
    }
}
