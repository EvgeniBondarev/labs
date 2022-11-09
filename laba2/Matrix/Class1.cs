using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class MatrixConvert
    {
        public int[,] Matrix;

        public MatrixConvert(int[,] Matrix)
        {
            this.Matrix = Matrix;
        }

        public MatrixConvert()
        {
            this.Matrix = new int[0, 0];
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", Matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static  MatrixConvert operator *(MatrixConvert matrix1, MatrixConvert matrix2)
        {
            MatrixConvert newWatrix = new MatrixConvert();
            if (matrix1.Matrix.Length == matrix2.Matrix.Length)
            {
                int[,] rezult = new int[matrix1.Matrix.GetLength(0), matrix2.Matrix.GetLength(1)];
                for (int i = 0; i < matrix1.Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.Matrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrix2.Matrix.GetLength(0); k++)
                        {
                            rezult[i, j] += matrix1.Matrix[i, k] * matrix2.Matrix[k, j];
                        }
                    }
                }
                newWatrix.Matrix = rezult;
                return newWatrix;
            }
            else
            {
                return newWatrix;
            }
            
        }

        public static MatrixConvert operator *(MatrixConvert matrix1, int num)
        {
            MatrixConvert newMatrix = new MatrixConvert();
            int[,] rezult = new int[matrix1.Matrix.GetLength(0), matrix1.Matrix.GetLength(1)];
            for (int i = 0; i < matrix1.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.Matrix.GetLength(1); j++)
                {
                    rezult[i, j] = matrix1.Matrix[i, j] * num;
                }
            }

            newMatrix.Matrix = rezult;
            return newMatrix;
        }

        public static bool operator ==(MatrixConvert matrix1, int[,] testArr)
        {
            
            for (int i = 0; i < matrix1.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < testArr.GetLength(1); j++)
                {
                    if(matrix1.Matrix[i, j] != testArr[i, j])
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }

        public static bool operator !=(MatrixConvert matrix1, int[,] testArr)
        {

            for (int i = 0; i < matrix1.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < testArr.GetLength(1); j++)
                {
                    if (matrix1.Matrix[i, j] != testArr[i, j])
                    {
                        return true;
                    }
                }

            }
            return false;
        }



    }
}
