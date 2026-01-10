using System;

namespace Task1_8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите 1-е число: ");
                    int value1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите 2-е число: ");
                    int value2 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("1 - cумма, 2 - разность, 3 - умножение, 4 - деление, 5 - выход.\nВыберите действие: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine($"Сумма чисел: {value1} + {value2} = {Sum(value1, value2)}"); break;
                        case 2:
                            Console.WriteLine($"Разность чисел: {value1} - {value2} = {Subtract(value1, value2)}"); break;
                        case 3:
                            Console.WriteLine($"Произведение чисел: {value1} * {value2} = {Multyply(value1, value2)}"); break;
                        case 4:
                            Console.WriteLine($"Деление первого числа на второе: {value1} / {value2} = {Divide(value1, value2):F2}"); break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Введите число от 1 до 5");
                            break;
                    }

                }
                catch (FormatException ex)
                {

                    Console.WriteLine($"Ошибка: Введено не целое число! - {ex.Message}");
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Ошибка: Деление на ноль! - {ex.Message}");
                }
                Console.WriteLine("-----------------------------------");
            }
        }

        static int Multyply(int value1, int value2)
        {
            return value1 * value2;
        }
        static int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
        static double Divide(int value1, int value2)
        {
            if (value2 == 0)
                throw new DivideByZeroException();
            return (double)value1 / value2;
        }

    }
}