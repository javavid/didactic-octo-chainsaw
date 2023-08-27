using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora._2
{
    internal class Operaciones
    {
        double resultado = 0;

        public Operaciones() 
        {
        }

        public double Suma(double v1, double v2) {
            try 
            {
                resultado = v1 + v2;
                return resultado;
            }
            catch 
            {
            return resultado;
            }
        }
        public double Resta(double v1, double v2)
        {
            try
            {
                resultado = v1 - v2;
                return resultado;
            }
            catch
            {
                return resultado;

            }
        }

        public double Multiplicar(double v1, double v2)
        {
            try
            {
                resultado = v1 * v2;
                return resultado;
            }
            catch
            {
                return resultado;
            }
        }

        public double Dividir(double v1, double v2)
        {
            try
            {
                resultado = v1 / v2;
                return resultado;
            }
            catch
            {
                return resultado;
            }
        }
    }
}
