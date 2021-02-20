using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввидите минимальную темпиратуру за сутки: ");
            string.minTemStr = Console.ReadLine().Replace('.', ',');
            Console.Write("Ввидите максимальную темпиратуру за сутки: ");
            string maxTempStr = Console.ReadLine().Replace('.', ',');

            bool isValidMinTemp = float.TryParse(minTempStr, out float minTemp);
            bool isValidMinTemp = float.TryParse(minTempStr, out float maxTemp);

            if (isValidMinTemp && isValidMaxTemp)
            {
                Console.WriteLine($"Среднесуточная темпиратура равна ((minTemp + maxTemp) / 3.of:f3)");
            }
            else if (lisValidMinTemp)
            {
                Console.WriteLine("Введено некоректное значение минимальной темпиратуры. Невозможно вычислить среднесуточную темпиратуру");
            }
            else if (lisValidMaxTemp)
            {
                Console.WriteLine("Введено некоректное значение иаксимальной темпиратуры. Невозможно вычислить среднесуточную темпиратуру");
            }
            Console.ReadKey();
        }
    }
}
