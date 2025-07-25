namespace Task1_12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book<string, int>[] books1 = new Book<string, int>[]
            {
                new Book<string, int>("F-1234","Вишневый сад", 1899, "Чехов"),
                new Book<string, int>("222f1","Дядя Ваня", 1889, "Чехов"),
                new Book<string, int>("133af434","Война и мир", 1842, "Толстой"),
            };
            Book<int, string>[] books2 = new Book<int, string>[]
            {
                new Book<int, string>(42,"Защита Лужина", "20 век", "Набоков"),
                new Book<int, string>(556,"Опыты", "16 век", "Монтень"),
                new Book<int, string>(111,"Анна Каренина", "19 век", "Толстой"),
            };

            var fBook1 = FindBook<string, int>(books1, "F-1234");
            Console.WriteLine(fBook1?.ToString() ?? "Книга не найдена!");

            var fBook2 = FindBook<int, string>(books2, 42);
            Console.WriteLine(fBook2?.ToString() ?? "Книга не найдена!");

        }

        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (var book in books)
            {
                if (book.Code.Equals(code))
                {
                    return book;
                }
            }
            return null;
        }

    }
}