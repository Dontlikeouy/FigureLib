using static System.Math;
namespace FigureLib
{
    public class Circle
    {
        /// <summary>
        /// Высчитывает площадь круга через радиус
        /// </summary>
        /// <param name="r"> радиус круга</param>
        /// <param name="digits"> Количество десятичных знаков </param>
        public double SquareRadius(double r, int digits = 1)
        {
            return Round(PI * Pow(r, 2), digits);
        }
        /// <summary>
        /// Высчитывает площадь круга через диаметр
        /// </summary>
        /// <param name="d"> диаметр круга</param>
        /// <param name="digits"> Количество десятичных знаков </param>
        public double SquareDiameter(double d, int digits = 1)
        {
            return Round((PI / 4) * Pow(d, 2), digits);
        }
    }
}

