using System;
using BibliotecaDeClases;

namespace Ejercicio04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumeroIngresado,
                    operacion,
                    respuesta;
            
            int primerOperando,
                segundoOperando;

            float resultado;

            do
            {
                Console.Write("Ingrese el primer numero: ");
                stringNumeroIngresado = Console.ReadLine();
                if (int.TryParse(stringNumeroIngresado, out primerOperando))
                {
                    Console.Write("Ingrese el segundo numero: ");
                    stringNumeroIngresado = Console.ReadLine();

                    if (int.TryParse(stringNumeroIngresado, out segundoOperando))
                    {
                        Console.Write("Ingrese la operacion (+, -, *, /): ");
                        operacion = Console.ReadLine();

                        resultado = Calculadora.Calcular(primerOperando, segundoOperando, operacion);

                        Console.WriteLine($"El resultado es: {resultado}");
                    }
                }

                Console.WriteLine("Desea continuar? (S/N)");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));

        }
    }
}
