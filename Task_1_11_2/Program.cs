namespace Task_1_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] iflyable = new IFlyable[]
                 {
                    new Bird (1500),
                    new Airplane(10000, 120)
                };

            foreach (var item in iflyable)
            {
                item.Fly();
            }
        }
    }
}