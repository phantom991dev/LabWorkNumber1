using System;

namespace LabWorkNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            //начало программы лаб 3
            double R, x, y, z;
            Console.Write("Введите R: ");
            R = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите x: ");
            x = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите y: ");
            y = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите z: ");
            z = Convert.ToSingle(Console.ReadLine());

            R = Math.Sqrt(2 * (x)) + 2 * y - 4 * x * y + z;

            //программа сделана на половину
        }
    }
}
