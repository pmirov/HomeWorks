namespace Task1_7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Multiply(2, 3)); 
            Console.WriteLine(Multiply(2.5, 3.5));

        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

    }

}