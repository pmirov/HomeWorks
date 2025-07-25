using System.Text;
using System.Text.RegularExpressions;

namespace Task1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            /*string s = Console.ReadLine();

            string[] subs = s.Split(' ');
            int maxLength = subs[0].Length;
            foreach (var sub in subs)
            {
                if (sub.Length > maxLength)
                {
                    maxLength = sub.Length;
                    Console.WriteLine($"Самое длинное слово: {sub}");
                }
               
            }*/

            //Задача 2

            /*string s = Console.ReadLine();

            string newS = (string)s.Replace(" ", "").ToLower();

            char[] chars = newS.ToCharArray();
            Array.Reverse(chars);

            string preparedS = new string(chars);

            if (newS.Equals(preparedS)) {
                Console.WriteLine("Предложение является полиндромом!");
                    } 
            else
            {
                Console.WriteLine("Предложение не является полиндромом!");
            }
            */

            //Задача 3

            /*Console.WriteLine("Введите месяц:");
            string month = Console.ReadLine();
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму продаж:");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество проданных товаров:");
            int count = Convert.ToInt32(Console.ReadLine());
            double medSum = sum / count;

            Console.WriteLine($"""
            --------------------------------
            Отчет о продажах за {month} {year} 
            --------------------------------
            Общая сумма продаж: {sum:N2} р.
            Количество проданных товаров: {count:N0} шт.
            Средняя стоимость товара: {medSum:N2} р.
            """);*/

            //Задача 4

            /*StringBuilder sb = new StringBuilder();
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите город:");
            string city = Console.ReadLine();
            sb.AppendLine($"Имя: {name}");
            sb.AppendLine($"Возраст: {age}");
            sb.AppendLine($"Город: {city}");
            Console.WriteLine(sb);*/

            //Задача 5

            /*string pattern = @"^\+\d{1}[(]\d{3}[)]\d{3}-\d{2}-\d{2}$";

            Regex regex = new Regex(pattern);

            while (true)
            {
                Console.WriteLine("Введите номер телефона в формате +7(913)890-58-16: ");
                string phone = Console.ReadLine();
                if (regex.IsMatch(phone))
                {
                    Console.WriteLine("Телефон введен верно");
                    break;
                }
                else Console.WriteLine("Введите заново!"); 
            }*/

            //Задача 6

            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!#;%:?*])[a-zA-Z\d!#;%:?*]{14,}$";
            
            Regex regex = new Regex(pattern);

            while (true)
            {
                Console.WriteLine("Введите пароль (мин. 14 символов, мин. одна цифра, заглавная буква, строчная букву и специальный символ !#;%:?*.):");
                string password = Console.ReadLine();
                if (regex.IsMatch(password))
                {
                    Console.WriteLine("Пароль подходит");
                    break;
                }
                else Console.WriteLine("Пароль не соотвествует условиям, введите заново!");
            }
           

        }
    }
}