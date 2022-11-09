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
        public void Matrix()
        {
            int[,] A = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            int[,] B = { { 2, 12, 23, 1 }, { 10, 29, 3, 43 }, { 11, 22, 37, 4 }, { 1, 2, 34, 4 } };
            int[,] testMatrix = { { 59, 144, 276, 115 }, { 59, 144, 276, 115 }, { 59, 144, 276, 115 }, { 59, 144, 276, 115 } };
            MatrixConvert matrix = new MatrixConvert(A);
            MatrixConvert matrix2 = new MatrixConvert(B);
            MatrixConvert matrix3 = new MatrixConvert();
            matrix3 = matrix * matrix2;
            matrix3.ShowMatrix();
            Assert.IsTrue(matrix3 == testMatrix);
        }
        [TestMethod()]
        public void MatrixConvertTest2()
        {
            int[,] A = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            int[,] testMatrix = { { 2, 4, 6, 8 }, { 2, 4, 6, 8 }, { 2, 4, 6, 8 }, { 2, 4, 6, 8 } };
            MatrixConvert matrix = new MatrixConvert(A);
            MatrixConvert matrix2 = new MatrixConvert();
            matrix2 = matrix * 2;
            matrix2.ShowMatrix();
            Assert.IsTrue(matrix2 == testMatrix);
        }
    }
}  