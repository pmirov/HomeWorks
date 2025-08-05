namespace _1_13_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите имя игрока:");
                string name = Console.ReadLine();
                Player player = new Player(name);
                Monster monster = new Monster();
                Console.WriteLine($"Битва начинается! {player.Name} против {monster.Name}!");
                while (player.isAlive && monster.isAlive)
                {
                    Console.WriteLine("Ваш ход:");
                    Console.WriteLine("1 - Атаковать / 2 - Использовать зелье здоровья");
                    int select = CheckData();


                    switch (select)
                    {
                        case 1:
                            player.Attack(monster);
                            break;
                        case 2:
                            player.UseHealthPotion();
                            break;
                    }

                    monster.Attack(player);

                    CurrentState(player, monster);

                }
                if (player.isAlive)
                {
                    Console.WriteLine("Ты выиграл!");
                }
                else if (monster.isAlive)
                {
                    Console.WriteLine("Ты проиграл!");
                }

                Console.WriteLine("хотите сыграть снова?");
                Console.WriteLine("1 - играть снова/ 2 - выход из игры");
                int answer = CheckData();
                if (answer == 2) break;
                else continue;
            }

        }

        static void CurrentState(Player player, Monster monster)
        {
            Console.WriteLine("Текущее состояние:");
            Console.WriteLine($"{player.Name}: {player.Health} HP");
            Console.WriteLine($"{monster.Name}: {monster.Health} HP");

        }

        static int CheckData()
        {
            while (true)
            {
                int select;

                try
                {
                    select = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный ввод, нужно ввести 1 или 2");
                    continue;
                }

                if (select == 1 || select == 2)
                {
                    return select;

                }
                else
                {
                    Console.WriteLine("Введите 1 или 2");
                }
            }
        }

    }

}