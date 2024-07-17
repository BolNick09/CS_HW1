using System;
using System.Linq;

namespace CS_HW1
{    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания (1-5):");
                int taskNumber = int.Parse(Console.ReadLine());

                switch (taskNumber)
                {
                    case 1:
                        FizzBuzz();
                        break;
                    case 2:
                        CalculatePercentage();
                        break;
                    case 3:
                        CreateNumber();
                        break;
                    case 4:
                        SwapDigits();
                        break;
                    case 5:
                        ConvertTemperature();
                        break;
                    default:
                        Console.WriteLine("Неверный номер задания.");
                        break;
                }
            }
        }

        private static void FizzBuzz()
        {
            Console.WriteLine("Введите число от 1 до 100:");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 100)
            {
                string result = "";
                if (number % 3 == 0)
                {
                    result += "Fizz";
                }
                if (number % 5 == 0)
                {
                    result += "Buzz";
                }
                if (result == "")
                {
                    result = number.ToString();
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Ошибка: введенное число не входит в диапазон от 1 до 100.");
            }
        }

        private static void CalculatePercentage()
        {
            Console.WriteLine("Введите значение:");
            double value;
            double.TryParse(Console.ReadLine(), out value);

            Console.WriteLine("Введите процент:");
            double percentage;
            double.TryParse(Console.ReadLine(), out percentage);


            double result = value * percentage/ 100;
            Console.WriteLine(percentage + "процентов от " + value + " равно " + result);
        }

        private static void CreateNumber()
        {
            Console.WriteLine("Введите четыре цифры:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int result = number1 * 1000 + number2 * 100 + number3 * 10 + number4;
            Console.WriteLine("Сформированное число:" + result);
        }

        private static void SwapDigits()
        {
            Console.WriteLine("Введите шестизначное число:");
            string number = Console.ReadLine();

            if (number.Length != 6)
            {
                Console.WriteLine("Ошибка: введенное число не является шестизначным.");
                return;
            }

            Console.WriteLine("Введите номера разрядов для обмена цифр (через пробел):");
            int[] indices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (indices.Length != 2)
            {
                Console.WriteLine("Ошибка: указано не два разряда для обмена.");
                return;
            }

            char[] numberArray = number.ToCharArray();
            char temp = numberArray[indices[0] - 1];
            numberArray[indices[0] - 1] = numberArray[indices[1] - 1];
            numberArray[indices[1] - 1] = temp;

            string result = new string(numberArray);
            Console.WriteLine("Число в результате: " + result);
        }

        private static void ConvertTemperature()
        {
            Console.WriteLine("Введите показания температуры:");
            double temperature = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите единицу измерения (F/C):");
            string unit = Console.ReadLine().ToUpper();

            double result;
            if (unit == "F")
            {
                result = (temperature - 32) * 5 / 9;
                Console.WriteLine(temperature + " градусов по шкале Фаренгейта равно " + result + " градусов по шкале Цельсия");
            }
            else if (unit == "C")
            {
                result = temperature * 9 / 5 + 32;
                Console.WriteLine(temperature + " градусов по шкале Цельсия равно " + result + " градусов по шкале Фаренгейта");
            }
            else
            {
                Console.WriteLine("Ошибка: неверная единица измерения.");
            }
        }
    }
}