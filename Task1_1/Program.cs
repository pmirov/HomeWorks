namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //задача 1

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //int t = a;
            //a = c;
            //c = t;

            //t = b;
            //b = c;
            //c = t;

            //Console.WriteLine($"a = {a}, b = {b}, c =  {c}"); 
            //Console.ReadKey();

            //задача 2

            //int gradus = Convert.ToInt32(Console.ReadLine());
            //int minute = Convert.ToInt32(Console.ReadLine());
            //int second = Convert.ToInt32(Console.ReadLine());

            //int signGradus = Math.Sign(gradus);

            //int ugol = (Math.Abs(gradus) * 3600 + minute * 60 + second) * signGradus;

            //double radian = ugol * Math.PI / (180 * 3600);

            //Console.WriteLine($"Значение угла в радианах: {radian}");

            //Задача 3

            //double length = Convert.ToDouble(Console.ReadLine());
            //const double inch = 2.54;

            //double mmLength = length*inch*10;

            //int m = (int)mmLength/1000;

            //int sm = (int)(mmLength%1000/10);

            //double mm = Math.Round(mmLength % 10, 1);

            //Console.WriteLine($"Длина отрезка:{m}м {sm}см {mm}мм");

            //Задача 4


            //int number = Convert.ToInt32(Console.ReadLine());

            //int firstNumber = number / 1000;
            //int secondNumber = number % 1000 / 100;
            //int thirdNumber = number % 100 / 10;
            //int forthNumber = number % 10;

            //int temp = secondNumber;

            //secondNumber = forthNumber;

            //forthNumber = temp;

            //int newNumber = firstNumber*1000+secondNumber*100+thirdNumber*10+forthNumber;

            //Console.WriteLine(newNumber);

            //Задача 5

            //double length = Math.Round(Convert.ToDouble(Console.ReadLine())/0.5)*0.5;
            //Console.WriteLine(length);

            //Задача 6

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            (a,b)=(b,a);

            Console.WriteLine($"a = {a} b = {b}");


        }
    }
}