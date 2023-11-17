using FigureLib;
namespace UnitTests
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void CircleSquareRadiusTest()
        {
            double hope = 314.2;
            double r = 10;

            var circle = new Circle();
            double result = circle.SquareRadius(r);

            if (result != hope)
            {
                throw (new Exception($"SquareRadius:{result}!={hope} - Value:{r}"));
            }
        }
    }
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
        public void TriangleSquareTest()
        {
            double hope = 43.3;
            int a = 10, b = 10, c = 10;

            var triangle = new Triangle();
            double result = triangle.Square(a, b, c);

            if (result != hope)
            {
                throw (new Exception($"Square:{result}!={hope} - Values:{a} {b} {c}"));
            }
        }

        [TestMethod]
        public void TriangleIsRectangleTest()
        {
            bool hope = true;
            int a = 15, b = 9, c = 12;

            var triangle = new Triangle();
            bool result = triangle.IsRectangle(a, b, c);

            if (result != hope)
            {
                throw (new Exception($"IsRectangle:{result}!={hope} - Values:{a} {b} {c}"));
            }
        }
    }
}