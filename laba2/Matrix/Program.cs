using System;

namespace Matrix
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] A = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            int[,] B = { { 2, 12, 23, 1 }, { 10, 29, 3, 43 }, { 11, 22, 37, 4 }, { 1, 2, 34, 4 } };

            
            MatrixConvert matr1 = new MatrixConvert(A);
            MatrixConvert matr2 = new MatrixConvert(B);
            MatrixConvert matr3 = new MatrixConvert();

            Console.WriteLine("\nМатрица A:");
            matr1.ShowMatrix();
            Console.WriteLine("\nМатрица B:");
            matr2.ShowMatrix();

            Console.WriteLine("\nРезультат умножения матрицы A на матрицу B");
            matr3 = matr1 * matr2;

            matr3.ShowMatrix();

            Console.WriteLine("\nРезультат умножения матрицы A на 2");
            matr1 = matr1 * 2;

            matr1.ShowMatrix();
 
        }

    }
}
