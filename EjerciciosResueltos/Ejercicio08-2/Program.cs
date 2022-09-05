using System;
using BibliotecaDeClases;

namespace Ejercicio08_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  diaIngresado,
                    mesIngresado,
                    annoIngresado;
            int dia,
                mes,
                anno;


            Console.WriteLine("Ingrese una fecha:");
            Console.Write("Dia:");
            diaIngresado = Console.ReadLine();
            if (int.TryParse(diaIngresado,out dia) && dia > 0 && dia <= 31)
            {
                Console.Write("Mes:");
                mesIngresado = Console.ReadLine();
                if (int.TryParse(mesIngresado,out mes) && mes > 0 && mes <= 12)
                {
                    Console.Write("Año:");
                    annoIngresado = Console.ReadLine();
                    if(int.TryParse(annoIngresado, out anno) && anno > 0 && anno <= DateTime.Now.Year)
                    {
                        Console.WriteLine($"Transcurrieron {Calculadora.CalcularDiasTranscurridos(dia,mes,anno)} dias desde {diaIngresado}/{mesIngresado}/{annoIngresado}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto!");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto!");
                }
            }
            else
            {
                Console.WriteLine("Incorrecto!");
            }
        }
    }
}
