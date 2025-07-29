namespace Task1_15_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> emailDatabase = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            emailDatabase.Add("alice@example.com");
            emailDatabase.Add("bob@example.com");
            emailDatabase.Add("charlie@example.com");
            bool hasDouble = emailDatabase.Add("Alice@example.com");
            Console.WriteLine($"Дубликат alice@example.com добавлен? {hasDouble}");
            bool hasBob = emailDatabase.Contains("bob@example.com");
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {hasBob}");
            bool hasDave = emailDatabase.Contains("dave@example.com");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {hasDave}");

            HashSet<string> newSubscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "bob@example.com", "dave@example.com", "eve@example.com"
            };
            HashSet<string> allEmails = new HashSet<string>(emailDatabase);
            allEmails.UnionWith(newSubscribers);
            Console.WriteLine("Подписчики после объединения:");
            foreach (var email in allEmails)
            {
                Console.WriteLine($"- {email}");
            }
            HashSet<string> commonEmails = new HashSet<string>(emailDatabase);
            commonEmails.IntersectWith(newSubscribers);
            Console.WriteLine("Общие подписчики:");
            foreach (var email in commonEmails)
            {
                Console.WriteLine($"- {email}");
            }
            bool hasDelete = allEmails.Remove("charlie@example.com");
            Console.WriteLine($"Удалили charlie@example.com? {hasDelete}");
            Console.WriteLine($"Всего подписчиков: {allEmails.Count}");
            HashSet<string> testGroup = new HashSet<string>()
            {
                "dave@example.com","alice@example.com"
            };
            bool isSubset = testGroup.IsSubsetOf(allEmails);
            Console.WriteLine($"Является ли testGroup подмножеством? {isSubset}");

            allEmails.Clear();
            Console.WriteLine($"Подписчиков после очистки: {allEmails.Count}");



        }
    }
}