namespace Task1_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Преступление и наказание", "Ф.М.Достоевский", 1866, 672);

            Console.WriteLine(book.GetInfo());
        }
    }
}