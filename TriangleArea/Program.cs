using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleLibrary;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это программа для рассчета площади треугольника по трём сторонам.");

            Console.WriteLine("Введите длину стороны a(дробная часть записывается с помощью точки):");
            var a = Console.ReadLine();
            Console.WriteLine("Введите длину стороны b(дробная часть записывается с помощью точки):");
            var b = Console.ReadLine();
            Console.WriteLine("Введите длину стороны c(дробная часть записывается с помощью точки):");
            var c = Console.ReadLine();
            // Вариант с предварительной проверкой(до запуска в метод)

            //double a = 0;
            //double b = 0;
            //double c = 0;
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите длину стороны a(дробная часть записывается с помощью точки):");
            //        a = Convert.ToDouble(Console.ReadLine(), new NumberFormatInfo());
            //        break;
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("Введено не числовое значение");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Значение слишком велико");
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите длину стороны b(дробная часть записывается с помощью точки):");
            //        b = Convert.ToDouble(Console.ReadLine(), new NumberFormatInfo());
            //        break;
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("Введено не числовое значение");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Значение слишком велико");
            //    }
            //}
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Введите длину стороны c(дробная часть записывается с помощью точки):");
            //        c = Convert.ToDouble(Console.ReadLine(), new NumberFormatInfo());
            //        break;
            //    }
            //    catch (FormatException e)
            //    {
            //        Console.WriteLine("Введено не числовое значение");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Значение слишком велико");
            //    }
            //}
            try
            {
                var result = Triangle.Area(a, b, c);
                Console.WriteLine(double.IsNaN(result) ? "Треугольника с такими сторонами существовать не может" : $"Площадь треугольника: {result}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
