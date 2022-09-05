using System;

namespace Ejercicio09_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numeroIngresadoString;
            int numeroIngresado,
                resultado;

            Console.Write("Ingrese numero:");
            numeroIngresadoString = Console.ReadLine();

            if(int.TryParse(numeroIngresadoString, out numeroIngresado))
            {
                resultado = numeroIngresado;

                for (int i = 1; i < numeroIngresado; i++)
                {
                    resultado *= i;
                }
                
                Console.WriteLine(resultado);
            }
        }
    }
}
