//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//    Потрібно: Створити статичний клас Calculator, з методами виконання основних арифметичних операцій. 
//    Написати програму, яка виводить на екран основні арифметичні операції.
namespace EssentialEx6
{
    static class Calculator
    {
        public static double Addition(double a, double b)
        {
            return a+b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Addition(1, 2));
            Console.WriteLine(Calculator.Subtraction(1, 2));
            Console.WriteLine(Calculator.Multiply(1, 2));
            Console.WriteLine(Calculator.Division(1, 2));
        }
    }
}