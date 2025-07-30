namespace _1_14_1
{
    internal class Program
    {
        public delegate int Transformer(int n);
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, -3, 5, 6 };

            int[] doubleValue = Transform(arr, n => n * 2);
            int[] squareValue = Transform(arr, n => n * n);
            int[] modulValue = Transform(arr, n => Math.Abs(n));
            Console.WriteLine($"Исходный массив: {string.Join(", ", arr)}");

            Console.WriteLine($"Удвоение всех чисел: {string.Join(", ", doubleValue)}");
            Console.WriteLine($"Возведение в квадрат: {string.Join(", ", squareValue)}");
            Console.WriteLine($"Замена числа на модуль: {string.Join(", ", modulValue)}");
        }
        static public int[] Transform(int[] arr, Transformer transformer)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = transformer(arr[i]);
            }
            return result;


        }
    }
}