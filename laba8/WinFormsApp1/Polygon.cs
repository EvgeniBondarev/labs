using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class Polygon : Figure, IComparable
    {

        public int[] Sides;
        public int Radius;
        public double Square;



        public Polygon(string type, string color, int radius, int[] sides) : base(type, color) { 
            Radius = radius;
            Sides = sides;
            Square = Math.Round(GetFigurePerimetr() * Radius * 1 / 2, 2);
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            if (obj is Polygon otherPolygon)
                return this.Square.CompareTo(otherPolygon.Square);
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public override double GetFigurePerimetr()
        {
            return Sides.Sum();
        }

        public override double GetFigureSquare()
        {
            return Square;
        }
        public override string ShowInfo()
        {
            return $"Многоугольник;  Площадь {GetFigureSquare()}; Кол-во сторон {Sides.Length}; Цвет {Color}";
        }


        
    }
}
