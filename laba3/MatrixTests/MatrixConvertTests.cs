using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Tests
{
    [TestClass()]
    public class MatrixConvertTests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            int[,] A = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            MatrixConvert matr1 = new MatrixConvert(A, "test");
            Assert.AreEqual(matr1.GetName(), "test");
            
        }
        [TestMethod()]
        public void GetLenghtTest()
        {
            int[,] A = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            MatrixConvert matr1 = new MatrixConvert(A, "test");
            Assert.AreEqual(matr1.MatrixLine(), 4);
            Assert.AreEqual(matr1.MatrixСolumn(), 4);
        }
        [TestMethod()]
        public void UpdateElementTest()
        {
            int[,] A = { { 1, -2, 3, 4 }, { -1, 2, -3, 4 }, { 1, -2, 3, 4 }, { 1, 2, 3, -4 } };
            int[,] B = { { 1, 2, 3, 4 }, { 3, 2, 1, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 0 } };
            MatrixConvert matr1 = new MatrixConvert(A, "test1");
            MatrixConvert matr2 = new MatrixConvert(B, "test2");
            matr1.UpdateElement(4);
            Assert.IsTrue(matr1 == matr2);

        }
        [TestMethod()]
        public void GetMinElementTest()
        {
            int[,] A = { { 1, -2, 3, 4 }, { -1, 2, -3, 4 }, { 1, -2, 3, 4 }, { 1, 2, 3, -4 } };
            MatrixConvert matr1 = new MatrixConvert(A, "test1");
            Assert.AreEqual(matr1.GetMinElement(), -4);
        }
        [TestMethod()]
        public void NotNullMatrixTest()
        {
            int[,] A = { { 1, -2, 3, 4 }, { -1, 2, -3, 4 }, { 1, -2, 3, 4 }, { 1, 2, 3, -4 } };
            MatrixConvert matr1 = new MatrixConvert(A, "test1");
            Assert.IsTrue(matr1.NotNullMatrix() == true);
        }
        [TestMethod()]
        public void NegativeMultiplicationTest()
        {
            int[,] A = { { 1, -2, 3, 4 }, { -1, 2, -3, 4 }};
            MatrixConvert matr1 = new MatrixConvert(A, "test1");
            Console.WriteLine(matr1.NegativeMultiplication());
            Assert.AreEqual(matr1.NegativeMultiplication(), -6);

        }
        [TestMethod()]
        public void AditionMatrexTest()
        {
            int[,] A = { { 1, -2, 3, 4 }, { -1, 2, -3, 4 }};
            int[,] B = { { 6, 9, 1, 2 }, { 1, 3, 6, 11 }};
            int[,] C = { { 7, 7, 4, 6 }, { 0, 5, 3, 15 } };
            MatrixConvert matr1 = new MatrixConvert(A, "test1");
            MatrixConvert matr2 = new MatrixConvert(B, "test2");
            MatrixConvert matr3 = new MatrixConvert(C, "test3");
            MatrixConvert matr4 = new MatrixConvert();

            Assert.IsTrue(matr1 + matr2 == matr3);


        }
    }
}  