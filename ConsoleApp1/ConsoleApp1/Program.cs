using System;

namespace SumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введiть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;

            Console.WriteLine($"Сума чисел: {sum}");
        }
    }
}
