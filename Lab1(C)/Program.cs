using System;

namespace Net.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 1 (option 18)");
            //18. Реализовать функцию возведения в куб целого числа
            int num;
            double pow = 0;
            Console.Write("Number = ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {//Проверка на вводимые данные
                Console.WriteLine("Input error!");
                Console.Write("Number = ");
            }
            pow = Math.Pow(num, 3);//Возводится в степень
            Console.WriteLine($"Answer: {pow}");
        }
    }
}
