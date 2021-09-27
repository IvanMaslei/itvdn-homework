using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_001_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle ra = new Rectangle();

            Console.WriteLine("Це калькулятор для обчислення площини та периметру прямокутника");
            Thread.Sleep(2500);
            Console.WriteLine("Для початку обрахунку, необхідно ввести ширину і довжину прямокутника");
            Thread.Sleep(2500);
            Console.WriteLine("Введи ширину прямокутника");
            ra.side1 = Int32.Parse(Console.ReadLine());
            Thread.Sleep(500);
            Console.WriteLine("Дані отримав. Тепер введи довжину прямокутника");
            ra.side2 = Int32.Parse(Console.ReadLine());
            Thread.Sleep(500);
            Console.Write("Проводжу обрахунок площини");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(200);
            }
            Console.WriteLine("Площина дорівнює " + ra.AreaCalculator());
            Thread.Sleep(500);
            Console.Write("Проводжу обрахунок периметру");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(200);
            }
            Console.WriteLine("Периметр дорівнює " + ra.PerimeterCalculator());
            Thread.Sleep(500);
            Console.WriteLine("Всі операції завершено");
            Console.ReadKey();
        }

    }
    class Rectangle
    {
        public double side1, side2;
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return side1 * 2 + side2 * 2;
        }
    }
}
