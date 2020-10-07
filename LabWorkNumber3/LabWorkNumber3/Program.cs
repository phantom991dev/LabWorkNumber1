using System;

namespace LabWorkNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            //начало программы лаб 3

            /*double R, x, y, z;
            Console.Write("Введите R: ");
            R = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите x: ");
            x = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите y: ");
            y = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите z: ");
            z = Convert.ToSingle(Console.ReadLine());

            R = Math.Sqrt(2 * (x)) + 2 * y - 4 * x * y + z;*/
            //начало программы
            double r, x, y, z;
            Console.Write("Введите r = ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите x = ");
            x = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите y = ");
            y = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите z = ");
            z = Convert.ToSingle(Console.ReadLine());

            r = Math.Sqrt(2 * (x)) + 2 * y - 4 * x * y + z;

            Console.WriteLine("\n\n");
            Console.WriteLine("Денежный формат {0:C} \n", r);
            Console.WriteLine("Экспоненциальный формат {0:E} \n", r);
            Console.WriteLine("Формат с фиксированной запятой {0:F3, 7} \n", r);
            Console.WriteLine("Общий формат {0:G} \n", r);
            Console.WriteLine("Числовой формат {0:N} \n", r);
            Console.WriteLine("Процентный формат {0:P} \n", r);
        }
    }
}
