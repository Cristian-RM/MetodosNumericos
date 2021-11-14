using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class CalcularMatriz
    {



        public  Matrix<double> Resolver(IABGenerador datos)
        {
            var builder = Matrix<double>.Build;

            //Se crean las matrices A y B a partir de los array
            var matrizA = builder.DenseOfArray(datos.generarA());
            var matrizB = builder.DenseOfArray(datos.generarB());

            var AtxA = (matrizA.Transpose().Multiply(matrizA)).Inverse();
            Console.WriteLine(AtxA.ToString());
            var AtxB = (matrizA.Transpose().Multiply(matrizB));

            return AtxA.Multiply(AtxB);

        }


    }
}
