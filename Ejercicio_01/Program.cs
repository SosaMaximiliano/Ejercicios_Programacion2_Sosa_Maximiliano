using System;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int acumulador = 0;
            int num;
            int max = 0;
            int min = 0;
            float promedio = 0f;
            string sNum;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Numero {i+1}:");
                sNum = Console.ReadLine();
                int.TryParse(sNum, out num);

                if (i==0)
                {
                    max = num;
                    min = num;
                }

                if (num < min)
                {
                    min = num;
                }

                if (num > max)
                {
                    max = num;
                }

                acumulador += num;
            }

            promedio = acumulador / 5;

            Console.WriteLine($"El minimo es: {min}");
            Console.WriteLine($"El maximo es: {max}");
            Console.WriteLine($"El promedio es: {promedio}");

        }
    }
}
