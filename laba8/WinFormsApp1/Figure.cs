using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    abstract class Figure
    {
        public  string Type { get; }
        public string Color { get; }


        public Figure(string type, string color, int[] cordinates)
        {
            Type = type;
            Color = color;

        }

        protected Figure(string type, string color)
        {
            Type = type;
            Color = color;
        }

        public virtual string ShowInfo()
        {
            return $"{Type} Color {Color} Square {GetFigureSquare()}";
        }


        public abstract double GetFigureSquare();
        public abstract double GetFigurePerimetr();


    }
}
