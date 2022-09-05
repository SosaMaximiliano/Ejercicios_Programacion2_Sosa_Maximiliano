using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class Calculadora
    {
        public static float Calcular(int primerOperando, int segundoOperando, string operacion)
        {
            float resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;

                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;

                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;

                case "/":
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("ERROR! El segundo operando no puede ser '0'");
                    }
                    break;

                default:
                    break;
            }

            return resultado;
        }

        private static bool Validar(int segundoOperando)
        {
            if (segundoOperando == 0)
            {
                return false;
            }

            return true;
        }

        public static string CalcularTablas(int numeroEntero)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i <= 10; i++)
            {
                resultado.AppendLine($"{numeroEntero} x {i} = {numeroEntero * i}");
            }

            return resultado.ToString();
        }

        public static double CalcularHipotenusa(double bbase, double altura)
        {
            return (Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(bbase, 2)));
        }

        public static int CalcularDiasTranscurridos(int diaIngresado, int mesIngresado, int annoIngresado)
        {
            int diaDelAnno = DateTime.Today.DayOfYear,
                mesDelAnno = DateTime.Today.Month,
                esteAnno = DateTime.Today.Year,
                diasTranscurridos = 0,
                diasARestar = 0;

            
                if (diaIngresado > 0 && diaIngresado <= 31 && mesIngresado > 0 && mesIngresado <= 12 && annoIngresado > 0 && annoIngresado <= esteAnno)
                {
                    for (int i = annoIngresado; i < esteAnno; i++)
                    {
                        for (int j = 1; j <= 12; j++)
                        {
                            diasTranscurridos += DateTime.DaysInMonth(i, j);
                        }
                    }

                    for (int k = 1; k < mesIngresado; k++)
                    {
                        diasARestar += DateTime.DaysInMonth(annoIngresado, k);
                    }

                    diasARestar += diaIngresado;
                    diasTranscurridos += diaDelAnno;

                }
                else
                {
                    Console.WriteLine("Fecha incorrecta");
                }
                    

            return diasTranscurridos - diasARestar;
        }
    }
}
