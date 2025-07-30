namespace Task1_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Введите возраст: ");
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    ValidateAge(age);
                    Console.WriteLine("Возраст введен в правильном диапазоне!");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Введено не целое число!");
                }
            }

        }

        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным!");
            if (age > 150)
                throw new ArgumentException("Возраст не может больше 150 лет!");
        }
    }
}