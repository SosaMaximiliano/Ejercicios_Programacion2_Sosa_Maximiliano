using System;
using BibliotecaDeClases;

namespace Ejercicio06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringNumeroIngresado;

            double numeroIngesado,
                    bbase,
                    altura;

            Console.WriteLine("Seleccione el area a calcular:\n" +
                "1: Cuadrado\n" +
                "2: Triangulo\n" +
                "3: Circulo");

            stringNumeroIngresado = Console.ReadLine();

            switch(stringNumeroIngresado)
            {
                case "1":
                    Console.Write("Ingrese longitud del lado:");
                    stringNumeroIngresado = Console.ReadLine();
                    double.TryParse(stringNumeroIngresado, out numeroIngesado);
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaCuadrado(numeroIngesado));
                    break;

                case "2":
                    Console.Write("Ingrese longitud de la base:");
                    stringNumeroIngresado = Console.ReadLine();
                    double.TryParse(stringNumeroIngresado, out bbase);

                    Console.Write("Ingrese altura:");
                    stringNumeroIngresado = Console.ReadLine();
                    double.TryParse(stringNumeroIngresado, out altura);
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaTriangulo(bbase, altura));
                    break;

                case "3":
                    Console.Write("Ingrese radio del circulo:");
                    stringNumeroIngresado = Console.ReadLine();
                    double.TryParse(stringNumeroIngresado, out numeroIngesado);
                    Console.WriteLine(CalculadoraDeArea.CalcularAreaCirculo(numeroIngesado));
                    break;
            }
        }
    }
}
