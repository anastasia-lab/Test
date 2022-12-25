using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Curcle : SquartShape
    {
        double _radius, sqrt;

        public Curcle(double Radius)
        {
            if (Radius <= 0)
                throw new ArgumentException("Error: Радиус не может быть меньше или равно нулю.");
            else
                this._radius = Radius;
        }

        /// <summary>
        /// площадь круга
        /// </summary>
        /// <returns></returns>
        public override double GetSquart()
        {
            sqrt = Math.Round(Math.PI * Math.Pow(_radius, 2));

            return sqrt;
        }
    }
}
