using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLibrary
{
    public class Triangle : SquartShape
    {
        double _oneSide, _twoSide, _threeSide, catheterOne, catheterTwo, hypotenuse;

        public Triangle(double SideOne, double SideTwo, double SideThree)
        {
            if (SideOne <= 0 || SideTwo <= 0 || SideThree <= 0)
                throw new ArgumentException("Error: Стороны треугольника не могут быть меньше или равно нулю.");
            else if (SideOne > (SideTwo + SideThree) || SideTwo > (SideOne + SideThree) ||
                SideThree > (SideOne + SideTwo))
                throw new ArgumentException("Error: Проверьте значения." + " " +
                    "Каждая сторона треугольника должна быть меньше суммы двух других.");
            else if (SideOne <= 0 || SideOne <= 0 || SideThree <=0)
               throw new ArgumentException  ("Error: Значения не могут быть меньше или равно нулю.");
            else
            {
                _oneSide = SideOne;
                _twoSide = SideTwo;
               _threeSide = SideThree;
            }

        }

        /// <summary>
        /// нахождение площади треугольника
        /// </summary>
        /// <returns></returns>

        public override double GetSquart()
        {
            double sqrtTriangle;
            double HalfMeterTriangle = (_oneSide + _twoSide + _threeSide) / 2; // вычисление полупериметра

            // умножение полупериметра на разности полуперитметра с тремя сторонами треугольника
            double perimeterTriangle = HalfMeterTriangle * (HalfMeterTriangle - _oneSide) * (HalfMeterTriangle - _twoSide) *
                (HalfMeterTriangle - _threeSide);

            sqrtTriangle = Math.Round(Math.Sqrt(perimeterTriangle));

            return sqrtTriangle;
        }

        /// <summary>
        /// нахождение гипотенузы прямоугольного треугольника
        /// </summary>
        /// <returns></returns>
        private double GetFindHypotenuse()
        {
            catheterOne = 0;
            catheterTwo = 0;
            hypotenuse = 0;

            if (_oneSide > _twoSide && _oneSide > _threeSide)
            {
                hypotenuse = _oneSide; catheterOne = _twoSide; catheterTwo = _threeSide;
            }

            else if (_twoSide > _oneSide && _twoSide > _threeSide)
            {
                hypotenuse = _twoSide; catheterOne = _oneSide; catheterTwo = _threeSide;
            }

            else if (_threeSide > _oneSide && _threeSide > _twoSide)
            {
                hypotenuse = _threeSide; catheterOne = _oneSide; catheterTwo = _twoSide;
            }

            return hypotenuse;
        }

        /// <summary>
        /// проверка, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangularTriangle 
        {
            get
            {
                GetFindHypotenuse();
                if (Math.Pow(hypotenuse, 2) == Math.Pow(catheterOne, 2) + Math.Pow(catheterTwo, 2))
                    return true;
                else return false;
            }
        }
    }
}
