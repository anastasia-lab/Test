using System;
using Xunit;
using ShapeLibrary;

namespace UnitTest
{
    public class UnitTest1
    {
        /// <summary>
        /// �������� ���������� ������� �����
        /// </summary>
        [Fact]
        public void TestSquartCurcle()
        {
            Curcle curcle = new Curcle(10);
            double result = curcle.GetSquart();
            Assert.Equal(314, result);
        }


        /// <summary>
        /// �������� ���������� ������� ������������
        /// </summary>
        [Fact]
        public void TestSquartTriangle()
        {
            Triangle triangle = new Triangle(9,40,41);
            double result = triangle.GetSquart();
            Assert.Equal(180,result);
        }

        /// <summary>
        /// �������� �������������� ������������
        /// </summary>
        [Fact]
        public void TestIsRectangularTriangle()
        {
            Triangle triangle = new Triangle(9, 40, 41);
            bool result = triangle.IsRectangularTriangle;
            Assert.True(result);
        }
    }
}
