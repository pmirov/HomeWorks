namespace task1_15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventoryStock = new Dictionary<string, int>();
            inventoryStock.Add("А001", 10);
            inventoryStock.Add("B205", 25);
            inventoryStock.Add("C307", 15);
            bool hasItem = inventoryStock.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с номером B205?: {hasItem}");
            inventoryStock["А001"] -= 2;
            inventoryStock.TryGetValue("C307", out int count);
            Console.WriteLine($"Количество наушников: {count}");
            inventoryStock["B205"] += 5;
            inventoryStock.Remove("C307");
            Console.WriteLine("Текущие товары:");
            foreach (var inventory in inventoryStock)
            {
                Console.WriteLine($"Артикул: {inventory.Key}, Количество: {inventory.Value}");
            }

            bool hasData = inventoryStock.Count< 0;

            Console.WriteLine($"Список пуст? {hasData}") ;
            inventoryStock.Clear();

            Console.WriteLine($"Количество товаров после очистки: {inventoryStock.Count}");

        }
    }
}