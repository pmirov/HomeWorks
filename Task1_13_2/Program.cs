using System.Text.RegularExpressions;

namespace Task1_13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 26;
            char[] chars = new char[m];
            int index = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                chars[index] = i;
                index++;
            }
            Regex regex = new Regex(@"^[^А-Яа-я]+$");

            while (true)
            {
                Console.WriteLine("Введит текст английскими буквами для шифрования: ");
                string inputText = Console.ReadLine();
                if (!regex.IsMatch(inputText))
                {
                    Console.WriteLine("Ввод кириллицы не допускается, введите текст английскими буквами");
                    continue;
                }

                char[] charText = inputText.ToUpper().ToCharArray();

                for (int i = 0; i < charText.Length; i++)
                {
                    if (charText[i] >= 'A' && charText[i] <= 'Z')
                    {

                        char target = charText[i];

                        int ind = Array.BinarySearch(chars, target);

                        charText[i] = chars[m - 2 - ind + 1];
                    }
                    else
                        continue;

                }

                Console.Write("Зашифрованный текст: ");
                foreach (var value in charText)
                {
                    Console.Write($"{value}");
                }
                Console.WriteLine();
            }
        }

    }
}
