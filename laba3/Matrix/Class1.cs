using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class MatrixConvert
    {
        private int[,] Matrix;
        private string NameMatrix;


        public MatrixConvert()
        {
            this.Matrix = new int[0,0];
            this.NameMatrix = "rezult";
        }
        public MatrixConvert(int[,] arr, string name)
        {
            this.Matrix = arr;
            this.NameMatrix = name;
        }

        public void InputMatrix()
        {
            this.NameMatrix = Console.ReadLine();

            this.Matrix = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < this.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.Matrix.GetLength(1); j++)
                {
                    Console.Write("A[{0},{1}] = ", i, j);
                    this.Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public int this[int i, int j]
        {
            get => this.Matrix[i, j];
            set => this.Matrix[i, j] = value;
        }

        public void ShowMatrix()
        {
            Console.Write($"Матрица: {NameMatrix}\n");

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", Matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public string GetName()
        {
            return NameMatrix;
        }

        public int MatrixСolumn()
        {
            return Matrix.GetLength(0);
        }

        public int MatrixLine()
        {
            return Matrix.GetLength(1);
        }

        public int[,] UpdateElement(int min)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] < 0)
                    {
                        Matrix[i, j] += min;
                    }


                }
            }
            return Matrix;
        }

        public int GetMinElement()
        {
            int lastLine = Matrix.GetLength(0) - 1;
            int min = Matrix[lastLine, 0];

            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                if(Matrix[lastLine, i] < min)
                {
                    min = Matrix[lastLine, i];
                }
            }
            return min;
        }

        public bool NotNullMatrix()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] == 0)
                    {
                        return false;
                    }
                    else break;
                    
                }
            }
            return true;

        }
        public int NegativeMultiplication()
        {
            int mult = 1;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] < 0)
                    {
                        mult *= Matrix[i, j];
                    }
                    

                }
            }
            return mult;
        }
        public void NegativeMultiplication(string name_matrix)
        {
            int mult = 1;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] < 0)
                    {
                        mult *= Matrix[i, j];
                    }
                    
                }
            }
            Console.WriteLine($"Произведение отрицательных элементов в матрицы {name_matrix}: {mult}");
        }


        public static MatrixConvert operator +(MatrixConvert matrix1, MatrixConvert matrix2)
        {
            MatrixConvert result = new MatrixConvert();
            if (matrix1.Matrix.GetLength(0) == matrix2.Matrix.GetLength(0) && matrix1.Matrix.GetLength(1) == matrix2.Matrix.GetLength(1))
            {
                result.Matrix = new int[matrix1.Matrix.GetLength(0), matrix1.Matrix.GetLength(1)];
                for (int i = 0; i < matrix1.Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.Matrix.GetLength(1); j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];
                    }
                }
            }
            return result;
        }
        public static bool operator ==(MatrixConvert matrix1, MatrixConvert matrix2)
        {

            for (int i = 0; i < matrix1.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.Matrix.GetLength(1); j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public static bool operator !=(MatrixConvert matrix1, MatrixConvert matrix2)
        {

            for (int i = 0; i < matrix1.Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.Matrix.GetLength(1); j++)
                {
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        return false;
                    }
                }

            }
            return true;
        }


    }
}