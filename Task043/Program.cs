// Напишите программу, которая найдёт точку пересечения
//  двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//  Например: 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task43
{
    class Program
    {
        static void Main(string[] args)
        {
            // y = k x + b
            double k1, b1, k2, b2;

            Console.Write("Введите k1: ");
            k1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b1: ");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите k2: ");
            k2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2: ");
            b2 = Convert.ToDouble(Console.ReadLine());

            // Приравниваем и решаем уравнение
            double x;
            x = solve(k1, b1, k2, b2);

            Console.WriteLine("Пересечение в точке " + x + "; " + (x * k1 + b1));
            Console.WriteLine("Вторая линия        " + x + "; " + (x * k2 + b2));

            Console.ReadLine();
        }

        // Метод решения
        static double solve(double k1, double b1, double k2, double b2)
        {
            double x;
            x = (b2 - b1) / (k1 - k2);
            return x;
        }
    }
}