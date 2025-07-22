namespace Task1_7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers); 
            PrintNumbers(numbers, true); 
        }
        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (reverse)
            {
                for (int i = numbers.Length - 1 ; i >= 0 ; i--)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}