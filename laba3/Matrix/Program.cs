using System;

namespace Matrix
{
    class Program
    {

        static void Main(string[] args)
        {
            MatrixConvert matr1 = new MatrixConvert();
            MatrixConvert matr2 = new MatrixConvert();
            MatrixConvert matr3 = new MatrixConvert();
            MatrixConvert sum_matr = new MatrixConvert();


            Console.WriteLine("Введите имя и размерность первой матрицы: ");
            matr1.InputMatrix();
            Console.Clear();

            Console.WriteLine("Введите имя и размерность второй матрицы: ");
            matr2.InputMatrix();
            Console.Clear();

            Console.WriteLine("Введите имя и размерность второй матрицы: ");
            matr3.InputMatrix();
            Console.Clear();

            matr1.ShowMatrix();
            Console.WriteLine("\n");
            matr2.ShowMatrix();
            Console.WriteLine("\n");
            matr3.ShowMatrix();
            Console.WriteLine("\n");

            Console.WriteLine($"Произведение отрицательных элементов в матрице {matr1.GetName()}: {matr1.NegativeMultiplication()}");
            matr1.NegativeMultiplication(matr2.GetName());
            Console.WriteLine($"Произведение отрицательных элементов в матрице {matr3.GetName()}: {matr3.NegativeMultiplication()}");
            Console.WriteLine("\n");


            sum_matr = matr1 + matr2;
            Console.Write($"{matr1.GetName()} + {matr2.GetName()} = ");
            sum_matr.ShowMatrix();

            if (matr1.NegativeMultiplication() > 6)
            {
                if (matr3.NotNullMatrix())
                {
                    int min = matr3.GetMinElement();
                    matr1.UpdateElement(min);
                }
            }

            matr1.ShowMatrix();






        }

    }
}
