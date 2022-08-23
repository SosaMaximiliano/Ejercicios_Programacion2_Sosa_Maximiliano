using System;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sNum;
            int num;
            double cuadrado;
            double cubo;

            Console.WriteLine("Numero:");
            sNum = Console.ReadLine();
            int.TryParse(sNum, out num);
            if (num > 0)
            {
                cuadrado = Math.Pow(num, 2);
                cubo = Math.Pow(num, 3);

                Console.WriteLine($"El cuadrado de {num} es: {cuadrado}");
                Console.WriteLine($"El cubo de {num} es: {cubo}");
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

        }
    }
}
