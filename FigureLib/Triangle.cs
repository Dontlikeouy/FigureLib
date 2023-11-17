using static System.Math;
namespace FigureLib
{
    public class Triangle
    {
        /// <summary>
        /// Высчитывает площадь треугольника по трём сторонам
        /// </summary>
        /// <param name="a"> Сторона A </param>
        /// <param name="b"> Сторона B </param>
        /// <param name="c"> Сторона C </param>
        /// <param name="digits"> Количество десятичных знаков </param>
        public double Square(int a, int b, int c, int digits = 1)
        {
            double p = (a + b + c) / 2;
            return Round(Sqrt(p * (p - a) * (p - b) * (p - c)), digits);
        }
        /// <summary>
        /// Проверяет является ли треугольник прямоугольным
        /// </summary>
        /// <param name="a"> Сторона A </param>
        /// <param name="b"> Сторона B </param>
        /// <param name="c"> Сторона C </param>
        public bool IsRectangle(int a, int b, int c)
        {
            if (Pow(a, 2) + Pow(b, 2) == Pow(c, 2) ||
                Pow(b, 2) + Pow(c, 2) == Pow(a, 2) ||
                Pow(a, 2) + Pow(c, 2) == Pow(b, 2))
                return true;
            return false;
        }
    }
}

