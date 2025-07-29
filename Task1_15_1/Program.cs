namespace Task1_15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> playerNamesList = new List<string>();

            playerNamesList.Add("Иванов");
            playerNamesList.Add("Петров");
            playerNamesList.Add("Сидоров");
            playerNamesList.Insert(1, "Козлов");
            bool hasName = playerNamesList.Contains("Петров");
            Console.WriteLine($"Есть Петров в списке? {hasName}");
            playerNamesList.Remove("Сидоров");
            int indexName = playerNamesList.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока \"Козлов\" {indexName}");
            playerNamesList.Sort();
            int ind = 1;
            Console.WriteLine("Текущий состав команды:");
            foreach (string playerName in playerNamesList)
            {
                Console.WriteLine($"{ind++}. {playerName}");
            }

            if(playerNamesList.Count() > 0)
            {
                Console.WriteLine("Список заполнен");
            }
            else
            {
                Console.WriteLine("Списко пуст");
            }
            playerNamesList.Clear();
            Console.WriteLine($"Количество игроков после очистки: {playerNamesList.Count()}");

        }
    }
}