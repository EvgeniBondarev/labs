using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Circle : Figure
    {
        public int[] Cordinates;
        public double Radius;

        public Circle(string type, int radius, int[] cordunates  ,string color) : base(type, color)
        {
            Radius = radius;
            Cordinates = cordunates;

        }

        public override double GetFigurePerimetr()
        {
            return Math.Round(Radius * Math.PI, 2);
        }

        public override double GetFigureSquare()
        {
            return Math.Round(Math.Pow(Radius, 2) * Math.PI, 2);
        }

        public bool IsI()
        {
            if (Cordinates[0] > 0 && Cordinates[1] > 0)
            {
                return true;
            }
            return false;
        }
        public override string ShowInfo()
        {
            return $"Круг;  Площадь {GetFigureSquare()}; Радиус {Radius}; Длинна окружности {GetFigurePerimetr()};  Цвет {Color}";
        }
    }
}
