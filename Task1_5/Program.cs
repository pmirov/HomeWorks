namespace Task1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задача 1

            /*Random random = new Random();
            int[] arr = new int[10];
            int evenCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
                Console.WriteLine(arr[i]);
                if (arr[i] % 2 == 0) evenCount++;


            }

            if (evenCount > arr.Length - evenCount)
                Console.WriteLine("Четных чисел больше");
            else if (evenCount < arr.Length - evenCount)
                Console.WriteLine("Нечетных чисел больше");
            else 
                Console.WriteLine("Количество четных чисел равно количеству нечетных");*/

            //Задача 2

            /*Random random = new Random();
            int[] arr = new int[10];
            int positiveCount = 0;
            int nullCount = 0;
            int negativeCount;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-20, 20);
                Console.Write(arr[i] + " ");
                if (arr[i] > 0) positiveCount++;
                if (arr[i] == 0) nullCount++;

            }

            negativeCount = arr.Length - positiveCount - nullCount;

            Console.WriteLine($"\n Количество положительных чисел: {positiveCount}\n Количество отрицательных чисел: {negativeCount}\n Количесво нулей: {nullCount}");*/

            //Задача 3

            /*Random random = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 50);
                Console.Write(arr[i] + " ");
            }

            int max = arr[0];
            int min = arr[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    maxIndex = i;
                }

                if (min > arr[i])
                {
                    min = arr[i];
                    minIndex = i;
                }

            }

            Console.WriteLine($"\n Максимальное значение массива {max}, номер индекса {maxIndex}\n Минимальное значение массива {min}, номер идекса {minIndex}");

            */

            //Задача 4

            /*Random random = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                if(i < arr.Length/2)
                {
                    temp = arr[i];
                    arr[i] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = temp;
                }
                Console.Write(arr[i] + " ");
            }*/

            //Задача 5

            /*Random random = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-50, 50);
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i < arr.Length / 2)
                {
                    for (int j = i + 1; j < arr.Length / 2; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                else
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }

            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }*/

            //Задача 6

            /*Random random = new Random();

            int n = 5;

            int[,] arr = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i%2 == 0 && j%2 == 0) || i%2 != 0 && j%2 != 0) arr[i, j] = 1;

                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }*/


            //Задача 7

            /*int n = 10, m = 5;
            Random random = new Random();

            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = random.Next(0, 10);

                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                int max = arr[i, 0];

                for (int j = 0; j < m; j++)
                {
                    if (max < arr[i,j])
                        max = arr[i,j];                    
                }
                Console.WriteLine($"Максимальное значение в строке №{i} = {max}");
            }*/

            //Задача 8

            /*Random random = new Random();
            int n = 5;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(0, 10);

                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {


                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                Console.Write(arr[i] + " ");
            }


            Console.WriteLine($"\nДва наибольших числа: {arr[0]}, {arr[1]}");


            */

            //Задача 9

            /*int n = 6, m = 4;
            int[,] arr = new int[n, m];
            int value = 1;
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = m - 1;


            while (top <= bottom && left <= right)
            {
                for (int j = left; j <= right; j++)
                {
                    arr[top, j] = value++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    arr[i, right] = value++;
                }
                right--;

                if (top > bottom || left > right) break;

                for (int j = right; j >= left; j--)
                {
                    arr[bottom, j] = value++;
                }
                bottom--;

                for (int i = bottom; i >= top; i--)
                {
                    arr[i, left] = value++;
                }
                left++;


            }

            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j],2} ");
                }
                Console.WriteLine();
            }*/


            //Задача 10

            const int n = 4;
            int[,] arr = new int[n, n];




            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = random.Next(0, 2);
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j],2}");
                }
                Console.WriteLine();
            }

            bool nullFlag = false;
            bool oneFlag = false;

            //проверка по гризонтали
            for (int i = 0; i < n; i++)
            {
                int nullCount = 0;
                int oneCount = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == 0)
                        nullCount++;
                    else
                        oneCount++;
                    if (nullCount == n) nullFlag = true;
                    if (oneCount == n) oneFlag = true;
                }
            }

            //проверка по вертикали
            for (int j = 0; j < n; j++)
            {
                int nullCount = 0;
                int oneCount = 0;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i, j] == 0)
                        nullCount++;
                    else
                        oneCount++;
                    if (nullCount == n) nullFlag = true;
                    if (oneCount == n) oneFlag = true;
                }
            }

            //проверка по диагонали

            int nullCountDiag = 0;
            int oneCountDiag = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i, i] == 0)
                    nullCountDiag++;
                else
                    oneCountDiag++;
                if (nullCountDiag == n) nullFlag = true;
                if (oneCountDiag == n) oneFlag = true;
            }

            //проверка второй диагонали

            nullCountDiag = 0;
            oneCountDiag = 0;
            for (int i = 0; i < n; i++)
            {
                int j = n -1 - i;
                if (arr[i, j] == 0)
                    nullCountDiag++;
                else
                    oneCountDiag++;
                if (nullCountDiag == n) nullFlag = true;
                if (oneCountDiag == n) oneFlag = true;
            }



            if (nullFlag && !oneFlag)
            {
                Console.WriteLine("Нолики выиграли");
            }
            else if (oneFlag && !nullFlag)
            {
                Console.WriteLine("Крестики выиграли");
            }
            else
            {
                Console.WriteLine("Ничья");
            }

        }
    }
}