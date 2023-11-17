using FigureLib;

//Круг
var circle = new Circle();
Console.WriteLine($"Площадь круга через радиус - {circle.SquareRadius(10)}");
Console.WriteLine($"Площадь круга через диаметр - {circle.SquareDiameter(10)}");


//Треугольник
var triangle = new Triangle();

int a = 15, b = 9, c = 12;
if (triangle.IsRectangle(a, b, c))
{
    Console.WriteLine($"Площадь треугольника через три стороны - {triangle.Square(a, b, c)}");
}
