using System;
using BibliotecaDeClases;

namespace Ejercicio05_2
{
/*Consigna
Crear una aplicación de consola que permita al usuario ingresar un número entero.
Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
Mostrar en la consola el resultado.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumeroIngresado;

            int numeroIngresado;

            Console.Write("Ingrese un numero entero: ");
            stringNumeroIngresado = Console.ReadLine();

            if(int.TryParse(stringNumeroIngresado, out numeroIngresado))
            {
                Console.WriteLine(Calculadora.CalcularTablas(numeroIngresado));
            }
            else 
            {
                Console.WriteLine("Incorrecto!");
            }
        }
    }
}
