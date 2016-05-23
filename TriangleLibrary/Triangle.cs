using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace TriangleLibrary
{
    public static class Triangle
    {
        /// <summary>
        /// Функция для рассчета площади треугольника по трём сторонам.
        /// Рассчёты производятся по формуле S = √p*(p - a)*(p - b)*(p - c) , где
        /// p - полупериметр треугольнка(сумма всех трёх сторон разделённая на 2)
        /// </summary>
        /// <param name="a">Сторона треугольника a</param>
        /// <param name="b">Сторона треугольника a</param>
        /// <param name="c">Сторона треугольника a</param>
        /// <returns>double значение площади треугольника</returns>
        public static double Area(double a, double b, double c)
        {
            if (a < 0.000001 || b < 0.000001 || a < 0.000001)
            {
                return Double.NaN;
            }
            if (!(a < (b + c)) || !(b < (a + c)) || !(c < (a + b))) return Double.NaN;
            var halfPerimeter = (a + b + c) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }

        public static double Area(string inputa, string inputb, string inputc)
        {
            return Area(inputa, inputb, inputc, new NumberFormatInfo());
        }

        public static double Area(string inputa, string inputb, string inputc, NumberFormatInfo numberFormat)
        {
            return Area(inputa, inputb, inputc, numberFormat, numberFormat, numberFormat);
        }

        public static double Area(string inputa, string inputb, string inputc, NumberFormatInfo numberFormata, NumberFormatInfo numberFormatb, NumberFormatInfo numberFormatc)
        {
            if (string.IsNullOrWhiteSpace(inputa))
                throw new ArgumentNullException(ArgumentNullA);
            if (string.IsNullOrWhiteSpace(inputb))
                throw new ArgumentNullException(ArgumentNullB);
            if (string.IsNullOrWhiteSpace(inputc))
                throw new ArgumentNullException(ArgumentNullC);
            var a = Convert.ToDouble(inputa, numberFormata);
            var b = Convert.ToDouble(inputb, numberFormatb);
            var c = Convert.ToDouble(inputc, numberFormatc);
            return Area(a, b, c);
        }

        private const string ArgumentNull = "Не введена сторона ";
        private const string ArgumentNullA = ArgumentNull + "a";
        private const string ArgumentNullB = ArgumentNull + "b";
        private const string ArgumentNullC = ArgumentNull + "c";
    }
}
