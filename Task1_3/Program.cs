using System.Net.WebSockets;

namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());

            if (value1 > value2)
                Console.WriteLine(">");
            else if (value1 < value2)
                Console.WriteLine("<");
            else Console.WriteLine("=");

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

            //Задача 12


            /*Console.WriteLine("Введите число в диапазоне от 100 до 999:");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value < 100 || value > 999)
            {
                Console.WriteLine("Данное число не входит в заданный диапазон!");
                return;
            }

            int value100 = value / 100;
            int value10 = (value % 100) / 10;
            int value11 = value % 100;
            int value1 = value % 10;

            string nameValue = "";

            switch (value100)
            {

                case 1:
                    nameValue += "Сто ";
                    break;
                case 2:
                    nameValue += "Двести ";
                    break;
                case 3:
                    nameValue += "Триста ";
                    break;
                case 4:
                    nameValue += "Четыреста ";
                    break;
                case 5:
                    nameValue += "Пятьсот ";
                    break;
                case 6:
                    nameValue += "Шетьсот ";
                    break;
                case 7:
                    nameValue += "Семьсот ";
                    break;
                case 8:
                    nameValue += "Восемьсот ";
                    break;
                case 9:
                    nameValue += "Девятьсот ";
                    break;

                default:
                    break;
            }

            if (value11 >= 11 && value11 < 20)
            {
                switch (value11)
                {
                    case 11:
                        nameValue += "одинадцать";

                        break;
                    case 12:
                        nameValue += "двенадцать";
                        break;
                    case 13:
                        nameValue += "тринадцать";
                        break;
                    case 14:
                        nameValue += "четырнадцать";
                        break;
                    case 15:
                        nameValue += "пятнадцать";
                        break;
                    case 16:
                        nameValue += "шестнадцать";
                        break;
                    case 17:
                        nameValue += "семнадцать";
                        break;
                    case 18:
                        nameValue += "восемнадцать";
                        break;
                    case 19:
                        nameValue += "девятнадцать";
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (value10)
                {
                    case 1:
                        nameValue += "десять ";

                        break;
                    case 2:
                        nameValue += "двадцать ";
                        break;
                    case 3:
                        nameValue += "тридцать ";
                        break;
                    case 4:
                        nameValue += "сорок ";
                        break;
                    case 5:
                        nameValue += "пятьдесят ";
                        break;
                    case 6:
                        nameValue += "шестьдесят ";
                        break;
                    case 7:
                        nameValue += "семьдесят ";
                        break;
                    case 8:
                        nameValue += "восемьдесят ";
                        break;
                    case 9:
                        nameValue += "девяносто ";
                        break;

                    default:
                        break;
                }


                switch (value1)
                {
                    case 1:
                        nameValue += "один";

                        break;
                    case 2:
                        nameValue += "два";
                        break;
                    case 3:
                        nameValue += "три";
                        break;
                    case 4:
                        nameValue += "четыре";
                        break;
                    case 5:
                        nameValue += "пять";
                        break;
                    case 6:
                        nameValue += "шесть";
                        break;
                    case 7:
                        nameValue += "семь";
                        break;
                    case 8:
                        nameValue += "восемь";
                        break;
                    case 9:
                        nameValue += "девять";
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(nameValue);

        }*/
        }

}

