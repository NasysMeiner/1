using System;

namespace _1_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            string baseStr = "компьютер";

            while (isWork)
            {
                Console.WriteLine("Enter number");
                string numStr = Console.ReadLine();
                string finalStr = "" + baseStr;
                int number = Convert.ToInt32(numStr) % 10;

                if (number == 2 || number == 3)//Конструкция, которая проверяет на склонение
                    finalStr += "а";
                else if (number != 1)
                    finalStr += "ов";

                numStr += $" {finalStr}";

                Console.Clear();
                Console.WriteLine($"Final result: {numStr}\nEnter '-' to exit");//Вывод результата
                numStr = Console.ReadLine();

                if (numStr == "-")//Выход из бесконечного цикла
                    break;
            }
        }
    }
}
