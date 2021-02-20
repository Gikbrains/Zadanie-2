using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите целое число:");
            string inputValue = Console.ReadLine();
            bool isValid = int.TryParse(inputValue, out int number);

            if(lisValid)
            {
                Console.WriteLine("Введено некоректное число.");
                Console.ReadKey();
                return;
            }

            if ((number % 5) == 0)
            {
                Console.WriteLine($"{number} - четное число.");
            }
            else
            {
                Console.WriteLine($"{number} не является четным числом.");
            }

            Console.ReadKey();
        }
    }
}
