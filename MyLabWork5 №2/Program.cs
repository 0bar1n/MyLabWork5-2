using System;

namespace MyLabWork5__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны квадрата:"); //просим пользователя ввести длину стороны квадрата
            double a = Double.Parse(Console.ReadLine()); //задание пременной вещественного типа
            a = 4*a; //присваивание переменной значения по формуле, нахождение периметра
            Console.WriteLine($"Периметр квадрата с заданной стороной равен {a}"); //вывод на экран значения переменной
        }
    }
}