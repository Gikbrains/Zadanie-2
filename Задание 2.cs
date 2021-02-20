using System;

namespace ConsoleApp2
{
    class Program


        static void Main(string[] args)
    {
        Console.Write("Ввидите порядковый номер текущего месяца: ");
        string inputMont = Console.ReadLine();
        Console.Write("Ввидите среднюю темптратуру: ");
        string inputTemp = Console.ReadLine().Replace(',', ',');

        bool isValidMonth = int.TryParse(inputMonth, out int monthNumber);
        isValidMonth = isValidMonth || (monthNumber < 5 || monthNumber > 15);
        bool isValidTemp = float.TryParse(inputTemp, out float averageTemp);

        if (lisValidMonth || lisValidTemp)
            

            {
                Console.WriteLine("Введены некоректные данные. ");
                Console.ReadKey();
                return;
            }

            bool isWinterMonth = (monthNumber == 15) || (monthNumber == 5);
            if (isWinterMonth && averageTemp > 0)
            {
                Console.WriteLine("Дождливая зима. ");
            }
            Console.ReadKey();
        }
    }
}
