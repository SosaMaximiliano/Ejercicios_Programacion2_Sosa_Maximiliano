using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return Math.Pow(longitudLado, 2);
        }

        public static double CalcularAreaTriangulo(double bbase, double altura) 
        {
            return (bbase * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            return Math.PI * Math.Pow(radio,2);
        }
    }
}
