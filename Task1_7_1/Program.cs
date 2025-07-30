namespace Task1_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Треугольник 1
            Console.WriteLine("Введите длину стороны a1:" );
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны b1:");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны c1:");
            double c1 = Convert.ToDouble(Console.ReadLine());
            double square1 = Square(a1, b1, c1);

            if (!IsTriangular(a1, b1, c1))
            {

                Console.WriteLine("Треугольник не образуется!");
                return;

            }
            else
                Console.WriteLine($"Площадь треугольника №1 равна: {square1:F2} ");

            //Треугольник 2
            Console.WriteLine("Введите длину стороны a2:");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны b2:");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны c2:");
            double c2 = Convert.ToDouble(Console.ReadLine());
            double square2 = Square(a2, b2, c2);



            if (!IsTriangular(a2, b2, c2))
            {

                Console.WriteLine("Треугольник не образуется!");
                return;

            }
            else
                Console.WriteLine($"Площадь треугольника №2 равна: {square2:F2} ");


            if (square2 < square1) Console.WriteLine("Площадь треугольника №1 больше площади треугольника №2");
            else if (square2 > square1) Console.WriteLine("Площадь треугольника №2 больше площади треугольника №1");
            else Console.WriteLine("Треугольники равны");


        }

        static bool IsTriangular(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
        static double Square(double a, double b, double c)

        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
    }
}