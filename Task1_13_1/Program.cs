namespace Task1_13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 100);
            Console.WriteLine(secretNumber);
            int tryNumber = 0;
            int count = 0;
            while (true)
            {
                count++;
                Console.Write("Угадайте число от 1 до 100: ");
                try
                {
                    tryNumber = Convert.ToInt32(Console.ReadLine());
                    if (tryNumber < 1 || tryNumber > 100)
                    {
                        throw new ArgumentException
                        ("Число дожно быть в диапазоне от 1 до 100");
                    }
                }
                catch (FormatException)
                {

                    Console.WriteLine($"Введено не целое число!");
                    continue;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                if (tryNumber == secretNumber)
                {
                    Console.WriteLine("Ты выиграл!");
                    Console.WriteLine($"Количество попыток: {count}");
                    break;
                }
                else if (tryNumber < secretNumber)
                {
                    Console.WriteLine("Больше!");
                }
                else
                {
                    Console.WriteLine("Меньше!");
                }

            }
        }
    }
}