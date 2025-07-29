namespace Task1_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] 
            {
                new Dog(),
                new Cat()
            };

            foreach (var animal in animals)
            {
                animal.ShowInfo();
            }
        }
    }
}