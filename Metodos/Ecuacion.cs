using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Ecuacion
    {
        public double[,] matriz { get; set; }
        public String escribirFuncion()
        {
            String funcion = "f(x) = ";
            String[] variables =
            {
                "","x","x^2","x^3"
            };
            for (int f = 0; f < matriz.Length; f++)
            {
                if (f > 0) funcion = funcion + " + ";
                funcion = funcion + matriz[f, 0].ToString() + "" + variables[f];

            }

            return funcion.Replace("+ -","- ");
        }
        public double ejecutarEcuacion(double x)
        {
            String funcion = "f(x) = ";
            double resultado = 0;
            int contador = 0;
            for (int f = 0; f < matriz.Length; f++)
            {
               if (f > 0)
                {
                    resultado = resultado +( Math.Pow(x, f) *matriz[f, 0]);
                }
                else
                {
                    resultado = resultado + matriz[f, 0];
                }

            }
            
            return resultado;
        }
       
    }
}
