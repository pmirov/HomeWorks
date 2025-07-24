namespace Task1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            int value = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;

            for (int i = 1; i <= value; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

            //Задача 2

            /*while (true)
            {
                int value = Convert.ToInt32(Console.ReadLine());

                double result = 0;

                for (int i = 1; i <= value; i++)
                {
                    result += 1.0/i;
                }

                Console.WriteLine(result);
            }*/

            //Задача 3

            /*while (true)
            {

                int a = Convert.ToInt32(Console.ReadLine());
                while (a <= 0)
                {
                    Console.WriteLine("Введите a больше нуля");
                    a = Convert.ToInt32(Console.ReadLine());
                }

                int b = Convert.ToInt32(Console.ReadLine());
                while (b <= 0)
                {
                    Console.WriteLine("Введите b больше нуля");
                    b = Convert.ToInt32(Console.ReadLine());
                }


                    long result = 1;

                for (int i = 1; i <= b; i++)
                {
                    result *= a;
                }

                Console.WriteLine(result);

            }*/

            //Задача 4

            //while(true)
            //{ 
            //    Console.WriteLine("Введите значение а: ");
            //    int a = Convert.ToInt32(Console.ReadLine());

            //    while (a <= 0)
            //    {
            //        Console.WriteLine("Введите a больше нуля");
            //        a = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Console.WriteLine("Введите значение b: ");

            //    int b = Convert.ToInt32(Console.ReadLine());
            //    while (b >= 0)
            //    {
            //        Console.WriteLine("Введите b меньше нуля");
            //        b = Convert.ToInt32(Console.ReadLine());
            //    }

            //    double result = 1;

            //    for (int i = 1; i <= b*(-1); i++)
            //    {
            //        result *= 1.0 / a;
            //    }

            //    Console.WriteLine(result);

            //}

            //Задача 5

            /*Console.WriteLine("Введите число от 20 до 60 включительно:");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a < 20 || a > 60)
            {
                Console.WriteLine("Ошибка ввода! Введите число от 20 до 60 включительно:");
                a = Convert.ToInt32(Console.ReadLine());
            }*/

            //Задача 6


            /*Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            while (result != a)
            {
                result *= 2;
                if (result > a)
                {
                    Console.WriteLine($"Число {a} не является степенью 2");
                    return;
                }

            }

            Console.WriteLine($"Число {a} является степенью 2");*/

            //Задача 7

            /*Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (a == 0)
            {
                Console.WriteLine("Количество цифр: 1");
            }
            else
            {
                while (a != 0)
                {
                    a /= 10;
                    count++;
                }

                Console.WriteLine($"Количество цифр: {count}");

            }*/


            //Задача 8
            /*while(true)
            {
                Console.WriteLine("Введите число:");
                int a = Convert.ToInt32(Console.ReadLine());

                int count = 0;
                int tempA = a;
                int revesedA = 0;
                int n = 1;

                while (tempA != 0)
                {
                    n *= 10;
                    tempA /= 10;
                    count++;

                }


                for (int i = 0; i < count; i++)
                {
                    n /= 10;
                    revesedA += (a % 10) * n;
                    a /= 10;

                }

                Console.WriteLine(revesedA.ToString());
            }*/







        }
    }
}