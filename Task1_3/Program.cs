using System.Net.WebSockets;

namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            /*int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());

            if (value1 > value2)
                Console.WriteLine(">");
            else if (value1 < value2)
                Console.WriteLine("<");
            else Console.WriteLine("=");*/

            //Задача 2

            /*int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            int value3 = Convert.ToInt32(Console.ReadLine());

            int maxValue;

            if (value1 > value2)
                maxValue = value1;
            else
                maxValue = value2;

            if (maxValue < value3)
                maxValue = value3;

            Console.WriteLine($"Максималное значение = {maxValue}");*/

            //Задача 3

            /*int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            int value3 = Convert.ToInt32(Console.ReadLine());
            int value4 = Convert.ToInt32(Console.ReadLine());

            int maxValue;

            maxValue = (value1 > value2) ? value1 : value2;
            maxValue = (maxValue > value3) ? maxValue : value3;
            maxValue = (maxValue > value4) ? maxValue : value4;

            Console.WriteLine("Максимальное значение: " + maxValue);*/

            //Задача 4

            /*int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            int value3 = Convert.ToInt32(Console.ReadLine());

            int maxValue;
            int minValue;

            if (value1 > value2)
            {
                maxValue = value1;
                minValue = value2;
            }
            else
            {
                maxValue = value2;
                minValue = value1;
            }
            if (maxValue < value3)
            {
                maxValue = value3;
            }
            else if (minValue > value3)

            {
                minValue = value3;
            }

            int medianValue;
            if (value1 != maxValue && value1 != minValue)
            {
                medianValue = value1;
            }
            else if (value2 != maxValue && value2 != minValue)
                medianValue = value2;
            else medianValue = value3;

            Console.WriteLine($"Медианное значение = {medianValue}");*/

            //Задача 5

            /*int value = Convert.ToInt32(Console.ReadLine());
            if (value % 10 == 0) Console.WriteLine("Да");
            else Console.WriteLine("Нет");*/

            //Задача 6

            /*int value = Convert.ToInt32(Console.ReadLine());
            if (value % 2 == 0) Console.WriteLine("Да");
            else Console.WriteLine("Нет");*/

            //Задача 7

            /*int value = Convert.ToInt32(Console.ReadLine());
            if (value / 100 == 0 && value % 10 != value) Console.WriteLine("Да");
            else Console.WriteLine("Нет");*/

            //Задача 8

            /*int value = Convert.ToInt32(Console.ReadLine());
            if (value >= -10 && value <= 10) Console.WriteLine("Да");
            else Console.WriteLine("Нет");*/


            //Задача 9

            /*int value = Convert.ToInt32(Console.ReadLine());
            if (value <= -10 || value >= 10) Console.WriteLine("Да");
            else Console.WriteLine("Нет");*/

            //Задача 10

            /*int value = Convert.ToInt32(Console.ReadLine());

            int choise;

            if ((value >= 5 && value <= 20)
                || value % 10 >= 5 && value % 10 <= 9
                || value % 10 == 0
                || value % 100 >= 11 && value % 100 <= 19)
                choise = 0;
            else if (value % 10 >= 2 && value % 10 <= 4)
                choise = 1;
            else choise = 2;

            switch (choise)
            {
                case 0:
                    Console.WriteLine($"Мы построили {value} домов");
                    break;
                case 1:
                    Console.WriteLine($"Мы построили {value} дома");
                    break;
                case 2:
                    Console.WriteLine($"Мы построили {value} дом");
                    break;
                default:
                    Console.WriteLine("Нет варианта");
                    break;
            }*/

            //Задача 11


            /*Console.WriteLine("Введите размеры участка:");
            Console.WriteLine("Сторона а:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сторона b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размеры дома p*q:");
            Console.WriteLine("Сторона p:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сторона q:");
            int q = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размеры дома r*s:");
            Console.WriteLine("Сторона r:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сторона s:");
            int s = Convert.ToInt32(Console.ReadLine());

            if ((p + r) <= a && (q + s) <= b)
                Console.WriteLine("Участок подходит");
            else if ((p + q) <= a && (r + s) <= b)
                Console.WriteLine("Участок подходит");
            else 
                Console.WriteLine("Участок не подходит");
        */


        }
        
    }
}
