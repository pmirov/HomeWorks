using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
        {
            new Computer("C01", "Dell XPS 13 9310", "Intel Core i7-1165G7", 2.8, 16, 512, 4, 1500, 5),
            new Computer("C02", "Apple MacBook Pro 16", "Apple M1 Pro", 3.2, 32, 1024, 16, 2500, 3),
            new Computer("C03", "HP Spectre x360 14", "Intel Core i7-1165G7", 2.8, 16, 512, 4, 1400, 6),
            new Computer("C04", "Lenovo ThinkPad X1 Carbon Gen 10", "Intel Core i7-1260P", 2.6, 16, 1024, 4, 1800, 4),
            new Computer("C05", "ASUS ROG Zephyrus G14", "AMD Ryzen 9 6900HS", 3.3, 32, 1024, 8, 2200, 2),
            new Computer("C06", "MSI Stealth 15M", "Intel Core i7-11375H", 3.3, 16, 512, 6, 1600, 5),
            new Computer("C07", "Acer Aspire 7", "AMD Ryzen 7 5800U", 1.9, 16, 512, 4, 1200, 8),
            new Computer("C08", "Huawei MateBook X Pro", "Intel Core i7-1165G7", 2.8, 16, 1024, 2, 1700, 35),
            new Computer("C09", "Gigabyte Aero 15 OLED", "Intel Core i9-11980HK", 3.3, 32, 2048, 8, 2700, 1),
            new Computer("C10", "Razer Blade 15", "Intel Core i7-12800H", 3.7, 32, 1024, 8, 2600, 2)
        };

            // все компьютеры с указанным процессором
            Console.Write("Введите название процессора:");
            string processorName = Console.ReadLine();
            var sortedComputersByProcessor = computers
                .Where(comp => comp.Processor
                .Contains(processorName, StringComparison.OrdinalIgnoreCase))
                .ToList();
            Console.WriteLine($"Компьютеры с процессором {processorName}:");
            ShowList(sortedComputersByProcessor);

            //все компьютеры с объемом ОЗУ не ниже, чем указано
            Console.Write("Введите минимальный объем ОЗУ:");
            int minRamSize;
            try
            {
                minRamSize = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошбика! Нужно ввести целое число!");
                return;
            }
            var sortedComputersByRam = computers
               .Where(comp => comp.RamSize >= minRamSize)
               .ToList();
            Console.WriteLine($"Компьютеры с ОЗУ не менее {minRamSize} Gb:");
            ShowList(sortedComputersByRam);

            //список, отсортированный по увеличению стоимости
            var computersOrderedByPrice = computers
                .OrderBy(comp => comp.Price)
                .ToList();
            Console.WriteLine($"Компьютеры отсортированные по увеличению стоимости:");
            ShowList(computersOrderedByPrice);

            //список, сгруппированный по типу процессора
            var computersOrderedByProcessor = computers
                .OrderBy(comp => comp.Processor)
                .ToList();
            Console.WriteLine($"Компьютеры отсортированные по типу процессора:");
            ShowList(computersOrderedByProcessor);

            //самый дорогой компьютер
            var mostExpensiveComputer = computers
                .OrderByDescending(comp => comp.Price)
                .FirstOrDefault();
            Console.WriteLine($"Cамый дорогой компьютер: {mostExpensiveComputer.Model}, цена: {mostExpensiveComputer.Price}$");

            //самый дешевый компьютер
            var сheapestComputer = computers
                .OrderBy(comp => comp.Price)
                .FirstOrDefault();
            Console.WriteLine($"Cамый дешевой компьютер: {сheapestComputer.Model}, цена: {сheapestComputer.Price}$");

            //хотя бы один компьютер в количестве не менее 30 штук
            bool computersWithQuantity = computers
                .Any(comp => comp.Quantity >= 30);
            string yesNo = computersWithQuantity ? "Есть" : "Нет";
            Console.WriteLine($"Хотя бы один комьютер в количестве не менее 30 штук: {yesNo}");


        }



        private static void ShowList(List<Computer> sortedComputers)
        {
            int count = 1;
            foreach (var computer in sortedComputers)
            {
                Console.WriteLine($"{count++}. {computer.ToString()}");
            }
            if (sortedComputers.Count == 0)
            {
                Console.WriteLine("Нет компьютеров, соответствующих критериям поиска");
            }
            Console.WriteLine();

        }
    }
}

public class Computer
{
    public string Id { get; set; }
    public string Model { get; set; }
    public string Processor { get; set; }
    public double ClockSpeed { get; set; }
    public int RamSize { get; set; }
    public int StorageSize { get; set; }
    public int GpuCores { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public Computer(string id, string model, string processor, double clockSpeed, int ramSize, int storageSize, int gpuCores, double price, int quantity)
    {
        Id = id;
        Model = model;
        Processor = processor;
        ClockSpeed = clockSpeed;
        RamSize = ramSize;
        StorageSize = storageSize;
        GpuCores = gpuCores;
        Price = price;
        Quantity = quantity;
    }
    public override string ToString()
    {
        return $"ID: {Id}, Модель: {Model}, CPU: {Processor}, частота: {ClockSpeed} GHz, ОЗУ: {RamSize} GB, объем диска: {StorageSize} GB, GPU: {GpuCores} GB, цена: {Price} $, кол-во: {Quantity}";
    }
}


