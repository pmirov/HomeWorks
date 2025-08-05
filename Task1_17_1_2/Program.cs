namespace Task1_17_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main запущен");

            int[] array = MakeArrayAsync(10).Result;
            double res = CalculateAverageAsync(array).Result;
            Console.WriteLine($"Среднее арифметическое: {res}");

            Console.WriteLine("Main завершен");
            Console.ReadKey();
        }

        static int[] MakeArray(int n)
        {
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 99);
                Console.Write($"{array[i]} ");
                Thread.Sleep(500);
            }

            Console.WriteLine("\nМассив сгенерирован!");
            return array;
        }

        static double CalculateAverage(int[] array)
        {
            Console.Write("Вычисление среднего арифметического...");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }

            double aver = (double)sum / array.Length;
            Thread.Sleep(1000);

            return aver;

        }

        static async Task<int[]> MakeArrayAsync(int n)
        {
            Console.WriteLine("Метод MakeArrayAsync запущен");
            int[] array = await Task.Run(() => MakeArray(n));

            Console.WriteLine("Метод MakeArrayAsync завершен");
            return array;

        }

        static async Task<double> CalculateAverageAsync(int[] array)
        {
            Console.WriteLine("Метод CalculateAverageAsync запущен");
            double result = await Task.Run(() => CalculateAverage(array));
            Console.WriteLine("\nМетод CalculateAverageAsync завершен");
            return result;
        }

    }
}