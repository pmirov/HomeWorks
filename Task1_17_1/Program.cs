namespace Task1_17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task<int[]> task1 = Task.Run(() => MakeArray(10));
            Task<double> task2 = task1.ContinueWith(t =>
            {
                int[] array = t.Result;
                return CalculateAverage(array);
            });

            Console.WriteLine(task2.Result);

            /*int[] array = MakeArray();

            double aver = calculateAverage(array);*/

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
            Console.Write("Вычисление среднего арифметического:");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }

            double aver = (double)sum / array.Length;
            Thread.Sleep(1000);

            return aver;

        }
    }
}