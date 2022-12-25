using System;
using ShapeLibrary;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("side one: ");
            double one = double.Parse(Console.ReadLine());

            Console.Write("side two: ");
            double two = double.Parse(Console.ReadLine());

            Console.Write("side three: ");
            double three = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(one, two, three);
            Console.WriteLine($"Площадь треугольника: {triangle.GetSquart()}");
            Console.WriteLine($"Треугольник прямоугольный? {triangle.IsRectangularTriangle}");

            Console.Write("radius: ");
            double radius = double.Parse(Console.ReadLine());

            Curcle curcle = new Curcle(radius);
            Console.WriteLine($"Площадь круга: {curcle.GetSquart()}");

            Console.ReadKey();
        }
    }
}
