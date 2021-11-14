using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class AproximacionCuadratica : IABGenerador
    {
        public int[] XLIST { get; set; }
        public int[] YLIST { get; set; }
        public double[,] generarA()
        {
            double[,] MatrizA = new double[XLIST.Length, 3];
            for (int i = 0; i < XLIST.Length; i++)
            {
                MatrizA[i, 0] = 1;
                MatrizA[i, 1] = XLIST[i];
                MatrizA[i, 2] = Math.Pow(XLIST[i], 2); 
            }
            return MatrizA;
        }

        public double[,] generarB()
        {
            double[,] MatrizB = new double[XLIST.Length, 1];

            for (int i = 0; i < YLIST.Length; i++)
            {
                MatrizB[i, 0] = YLIST[i];
            }
            return MatrizB;
        }
    }
}
