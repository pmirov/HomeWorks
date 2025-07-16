namespace Task1_7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону куба: ");
            double edgeLength = Convert.ToDouble(Console.ReadLine());
            double volume, surfaceArea;
            CalcCube(edgeLength, out volume, out surfaceArea);
            Console.WriteLine($"Объем куба: {volume}"); 
            Console.WriteLine($"Площадь поверхности куба: {surfaceArea}"); 

        }

        static void CalcCube(double edgeLength, out double volume, out double surfaceArea)
        {
            volume = edgeLength * edgeLength * edgeLength;
            surfaceArea = edgeLength * edgeLength * 6;
        }
    }
}