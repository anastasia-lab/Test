using System;

namespace ShapeLibrary
{
    public class SquartShape
    {
        double squartShape { get; set; }

        /// <summary>
        /// площадь фигуры
        /// </summary>
        /// <returns></returns>
        public virtual double GetSquart()
        {
            return squartShape;
        }
    }
}
