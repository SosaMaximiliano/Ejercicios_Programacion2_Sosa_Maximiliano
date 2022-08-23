using System;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string sNum;
            int contador = 0;

            Console.Write("Numero: ");

            sNum = Console.ReadLine();
            int.TryParse(sNum, out num);

            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        contador += i;
                    }
                }

                if (contador == i)
                {
                    Console.WriteLine(i);
                }
                contador = 0;
            }
        }
    }
}
