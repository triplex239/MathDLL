using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MYMATH;

namespace Kopylov.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы знаете тип фигуры? да/нет: ");
            string nachalo = Convert.ToString(Console.ReadLine());
            if (nachalo == "да")
            {
                Console.WriteLine("У нас треугольник или круг?: ");
                string figura = Convert.ToString(Console.ReadLine());
                string upperFigura = figura.ToUpper();
                if (upperFigura == "ТРЕУГОЛЬНИК")
                {
                    Console.WriteLine("Что найдём? S или P ");
                    string poisk = Convert.ToString(Console.ReadLine());
                    string UpperPoisk = poisk.ToUpper();
                    Console.WriteLine("введите сторону треугольника x: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("введите сторону треугольника y: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("введите сторону треугольника z: ");
                    double z = Convert.ToDouble(Console.ReadLine());
                    if (poisk == "S")
                    {
                        Console.WriteLine("Площадь = " + MyMath.Square(x, y, z));
                    }
                    else if (poisk == "P")
                    {
                        Console.WriteLine("Периметр = " + MyMath.Perimeter(x, y, z));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    Console.WriteLine("Хотетите определить прямоугольый ли треуголник? да/нет: ");
                    string otvet = Convert.ToString(Console.ReadLine());
                    if (otvet == "да")
                    {
                        if (MyMath.Rectangular(x, y, z))
                        {
                            Console.WriteLine("Треугольник прямоугольный");
                        }
                        else
                        {
                            if ((x == y) || (x == z) || (z == y))
                                Console.WriteLine("Треугольник равнобедренный");
                            else
                                Console.WriteLine("Треугольник не прямоугольный");
                        }
                    }
                }
                else if (upperFigura == "КРУГ")
                    Console.WriteLine("введите радиус r: ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Что найдём? S или P ");
                char a = Convert.ToChar(Console.ReadLine());
                if (a == 'S')
                {
                    Console.WriteLine("Площадь = " + MyMath.Square(r));
                }
                else
                {
                    Console.WriteLine("Периметр = " + MyMath.Perimeter(r));
                }
                Console.ReadKey();
            }
            else if (nachalo == "нет")
            {   
                Console.WriteLine("Найдём площадь фигуры по координатам");
                int n;
                Console.WriteLine("сколько точек у фигуры? :");
                n = Convert.ToInt32(Console.ReadLine());
                double[] arrayX = new double[n];
                double[] arrayY = new double[n];

                for (int i = 0; i < n; i++)
                {
                    String point_name = "X" + i;
                    Console.WriteLine("Введите координаты точки " + point_name);
                    Console.WriteLine("координата X: ");
                    arrayX[i] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("координата Y: ");
                    arrayY[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine(MyMath.ArrayCoordinates(arrayX, arrayY));
                Console.ReadKey();
            }
        }
    }
}