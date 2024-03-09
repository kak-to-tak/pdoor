using System;
using System.IO;

namespace MyGame
{
    class Program
    {
        // Игрок
        private static string playerName;
        private static int playerHealth = 100;
        private static int playerAttack = 10;
        private static int playerDefense = 5;
        private static int playerLevel = 1;
        private static int playerExperience = 0;
        private static int playerGold = 0;

        // Текущая комната
        private static string currentRoom;

        // Сохраненные данные
        private static string saveFileName = "save.txt";

        static void Main(string[] args)
        {
            // Приветствие
            Console.WriteLine("Добро пожаловать в текстовое приключение!");
            Console.WriteLine("Введите свое имя:");
            playerName = Console.ReadLine();

            // Начало игры
            currentRoom = "Начальная комната";
            GameLoop();
        }

        private static void GameLoop()
        {
            while (true)
            {
                // Вывод информации о комнате
                Console.WriteLine($"Вы находитесь в {currentRoom}.");

                // Вывод информации об игроке
                Console.WriteLine($"Здоровье: {playerHealth}");
                Console.WriteLine($"Уровень: {playerLevel}");
                Console.WriteLine($"Опыт: {playerExperience}");
                Console.WriteLine($"Золото: {playerGold}");

                // Вывод доступных действий
                Console.WriteLine("Доступные действия:");
                Console.WriteLine("1. Идти на север");
                Console.WriteLine("2. Идти на восток");
                Console.WriteLine("3. Идти на юг");
                Console.WriteLine("4. Идти на запад");
                Console.WriteLine("5. Атаковать");
                Console.WriteLine("6. Исследовать");
                Console.WriteLine("7. Сохранить игру");
                Console.WriteLine("8. Загрузить игру");
                Console.WriteLine("9. Выход");
                Console.WriteLine();

                // Ввод действия
                int action = int.Parse(Console.ReadLine());

                // Обработка действия
                switch (action)
                {
                    case 1:
                        GoNorth();
                        break;
                    case 2:
                        GoEast();
                        break;
                    case 3:
                        GoSouth();
                        break;
                    case 4:
                        GoWest();
                        break;
                    case 5:
                        Attack();
                        break;
                    case 6:
                        Explore();
                        break;
                    case 7:
                        SaveGame();
                        break;
                    case 8:
                        LoadGame();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
        }

        private static void GoNorth()
        {
            if (currentRoom == "Начальная комната")
            {
                currentRoom = "Северная комната";
            }
            else
            {
                Console.WriteLine("Вы не можете идти на север.");
            }
        }

        private static void GoEast()
        {
            if (currentRoom == "Начальная комната")
            {
                currentRoom = "Восточная комната";
            }
            else
            {
                Console.WriteLine("Вы не можете идти на восток.");
            }
        }

        private static void GoSouth()
        {
            if (currentRoom == "Начальная комната")
            {
                currentRoom = "Южная комната";
            }
            else
            {
                Console.WriteLine("Вы не можете идти на юг.");
            }
        }

        private static void GoWest()
        {
            if (currentRoom == "Начальная комната")
            {
                currentRoom = "Западная комната";
            }
            else
            {
                Console.WriteLine("Вы не можете идти на запад.");
            }
        }

        private static void Attack()
        {
            // Проверка наличия врагов
            if (currentRoom == "Северная комната")
            {
                // Создание врага
                Enemy enemy = new Enemy("Гоблин", 50, 5, 2);

                // Бой
                while (enemy.Health > 0 && playerHealth > 0)
                {
                    // Атака игрока
                    int damage = playerAttack - enemy.Defense;
                    enemy.Health -= damage;
                    Console.WriteLine($"Вы нанесли {damage} урона гоблину.");

                    // Атака врага
                    damage = enemy.Attack - playerDefense;
                    playerHealth -= damage;
                    Console.WriteLine($"Гоблин нанес вам {damage} урона.");
                }

                // Результат боя
                if (enemy.Health <= 0)
                {
                    Console.WriteLine("Вы победили гоблина!");
                    playerExperience += 10;
                    playerGold += 5;
                }
                else
                {
                    Console.WriteLine("Вы проиграли гоблину.");
                    playerHealth = 0;
                }
            }
            else
            {
                Console.WriteLine("Здесь нет врагов.");
            }
        }

        private static void Explore()
        {
            // Проверка наличия предметов
            if (currentRoom == "Восточная комната")
            {
                // Создание предмета
                Item item = new Item("Меч", 10);

                // Получение предмета
                playerAttack += item.Attack;
                Console.WriteLine($"Вы нашли {item.Name}.");
            }
            else
            {
                Console.WriteLine("Здесь нет предметов.");
            }
        }

        private static void SaveGame()
        {
            // Создание файла сохранения
            using (StreamWriter writer = new StreamWriter(saveFileName))
            {
                writer.WriteLine(playerName);
                writer.WriteLine(playerHealth);
                writer.WriteLine(playerAttack);
                writer.WriteLine(playerDefense);
                writer.WriteLine(playerLevel);
                writer.WriteLine(playerExperience);
                writer.WriteLine(playerGold);
                writer.WriteLine(currentRoom);
            }

            Console.WriteLine("Игра сохранена.");
        }

        private static void LoadGame()
        {
            // Проверка наличия файла сохранения
            if (File.Exists(saveFileName))
            {
                // Загрузка файла сохранения
                using (StreamReader reader = new StreamReader(saveFileName))
                {
                    playerName = reader.ReadLine();
                    playerHealth = int.Parse(reader.ReadLine());
                    playerAttack = int.Parse(reader.ReadLine());
                    playerDefense = int.Parse(reader.ReadLine());
                    playerLevel = int.Parse(reader.ReadLine());
                    playerExperience = int.Parse(reader.ReadLine());
                    playerGold = int.Parse(reader.ReadLine());
                    currentRoom = reader.ReadLine();
                }

                Console.WriteLine("Игра загружена.");
            }
            else
            {
                Console.WriteLine("Файл сохранения не найден.");
            }
        }
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public Enemy(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }
    }

    class Item
    {
        public string Name { get; set; }
        public int Attack { get; set; }

        public Item(string name, int attack)
        {
            Name = name;
            Attack = attack;
        }
    }
}