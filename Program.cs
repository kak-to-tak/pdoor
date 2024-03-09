using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game
{
    internal class Program
    {
        //Игрок
        private static string pName;
        private static string pOrydie = "Лопата";
        private static int pExperience = 0;
        private static int pMoney = 1000;
        private static int iAccuracy = 50;
        private static int iSpeed = 1;

        private static int countLopata = 1;
        private static int countMolotok = 0;
        private static int countSHtlopata = 0;
        private static int countKirka = 0;
        private static int countByr = 0;
        private static int count9bloko = 0;
        private static int Yabloko = 10;
        private static int countByrger = 0;
        private static int Byrger = 30;
        private static int countPivo = 0;
        private static int Pivo = 100;
        private static int hpKamen = 1;
        private static int hpZhelezo = 3;
        private static int hpDollar = 5;
        private static int hpZoloto = 10;
        private static int hpAlmazbl = 15;
        private static int satiety = 100;

        private static bool shahtaNach = true;
        private static bool shahtaZhelezo = false;
        private static bool shahtaDollarbl = false;
        private static bool shahtaZoloto = false;
        private static bool shahtaAlmazbl = false;

        private static string choiseShahta;

        private static string saveFileName = "sohranenie.txt";
        static void Main(string[] args)
        {
            //Начало игры
            Console.WriteLine("Приветсвую тебя в игре HappyMiner!");
            Console.WriteLine("Введите свой ник: ");
            pName = Console.ReadLine();

            Console.WriteLine();

            choiseShahta = "Дом";
            Game();
        }
        private static void Shahtbl()
        {

            Console.WriteLine("-------Шахты-------");
            Console.WriteLine("1. Начальная шахта");
            Console.WriteLine("2. Шахта с железом");
            Console.WriteLine("3. Шахта с долларами");
            Console.WriteLine("4. Шахта с золотом");
            Console.WriteLine("5. Шахта с алмазами");
            Console.WriteLine("6. Меню");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            int choise = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (choise)
            {
                case 1:
                    if (shahtaNach == true)
                    {
                        choiseShahta = "Начальная шахта";
                    };
                    break;

                case 2:
                    if (shahtaZhelezo == true)
                    {
                        choiseShahta = "Шахта с железом";
                    }
                    else
                    {
                        Console.WriteLine("Шахта недоступна!");
                    }
                    break;

                case 3:
                    if (shahtaZhelezo == true)
                    {
                        choiseShahta = "Шахта с долларами";
                    }
                    else
                    {
                        Console.WriteLine("Шахта недоступна!");
                    }
                    break;
                case 4:
                    if (shahtaZhelezo == true)
                    {
                        choiseShahta = "Шахта с золотом";
                    }
                    else
                    {
                        Console.WriteLine("Шахта недоступна!");
                    }
                    break;
                case 5:
                    if (shahtaZhelezo == true)
                    {
                        choiseShahta = "Шахта с алмазами";
                    }
                    else
                    {
                        Console.WriteLine("Шахта недоступна!");
                    }
                    break;
                case 6:
                    break;
            }
        }
        private static void Magazin()
        {

            Console.WriteLine("------Магазин------");
            Console.WriteLine("1. Еда");
            Console.WriteLine("2. Инструмент");
            Console.WriteLine("3. Шахты");
            Console.WriteLine("4. Меню");
            Console.WriteLine("-------------------");

            Console.WriteLine();
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choise)
            {
                case 1:

                    Console.WriteLine("-------Еда-------");
                    Console.WriteLine("1. Яблоко - 1");
                    Console.WriteLine("2. Бургер - 5");
                    Console.WriteLine("3. Пиво - 10");
                    Console.WriteLine("4. Меню");
                    Console.WriteLine("-----------------");

                    Console.WriteLine();
                    choise = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choise)
                    {
                        case 1:
                            if (pMoney - 1 >= 0)
                            {
                                pMoney -= 1;
                                Console.WriteLine("Вы купили яблоко");
                                count9bloko += 1;
                            }
                            else if (pMoney - 1 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            break;

                        case 2:
                            if (pMoney - 5 >= 0)
                            {
                                pMoney -= 5;
                                Console.WriteLine("Вы купили бургер");
                                countByrger += 1;
                            }
                            else if (pMoney - 5 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            break;

                        case 3:
                            if (pMoney - 5 >= 0)
                            {
                                pMoney -= 10;
                                Console.WriteLine("Вы купили пиво");
                                countPivo += 1;
                            }
                            else if (pMoney - 5 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            break;
                    }
                    break;
                case 2:

                    Console.WriteLine("----Инструменты----");
                    Console.WriteLine("1. Лопата - 1");
                    Console.WriteLine("2. Молоток - 2");
                    Console.WriteLine("3. Штыковая лопата - 3");
                    Console.WriteLine("4. Кирка - 4");
                    Console.WriteLine("5. Бур - 5");
                    Console.WriteLine("6. Меню");
                    Console.WriteLine("-------------------");

                    Console.WriteLine();
                    choise = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choise)
                    {
                        case 1:
                            if (pMoney - 1 >= 0)
                            {
                                pMoney -= 1;
                                Console.WriteLine("Вы приобрели лопату");
                                countLopata += 1;
                                Console.WriteLine();
                            }
                            else if (pMoney - 1 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            if (pMoney - 2 >= 0)
                            {
                                pMoney -= 2;
                                Console.WriteLine("Вы приобрели молоток");
                                countMolotok += 1;
                                Console.WriteLine();
                            }
                            else if (pMoney - 1 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            if (pMoney - 3 >= 0)
                            {
                                pMoney -= 3;
                                Console.WriteLine("Вы приобрели штыковую лопату");
                                countSHtlopata += 1;
                                Console.WriteLine();
                            }
                            else if (pMoney - 1 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            if (pMoney - 4 >= 0)
                            {
                                pMoney -= 4;
                                Console.WriteLine("Вы приобрели кирку");
                                countKirka += 1;
                                Console.WriteLine();
                            }
                            else if (pMoney - 1 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            break;
                        case 5:
                            if (pMoney - 5 >= 0)
                            {
                                pMoney -= 5;
                                Console.WriteLine("Вы приобрели бур");
                                countByr += 1;
                                Console.WriteLine();
                            }
                            else if (pMoney - 1 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            break;
                        case 6:
                            break;
                    }
                    break;
                case 3:

                    Console.WriteLine("-------Шахты-------");
                    Console.WriteLine("1. Шахта с железом - 1");
                    Console.WriteLine("2. Шахта с долларами - 2");
                    Console.WriteLine("3. Шахта с золотом - 3");
                    Console.WriteLine("4. Шахта с алмазами - 4");
                    Console.WriteLine("5. Меню");
                    Console.WriteLine("-------------------");

                    Console.WriteLine();
                    choise = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choise)
                    {
                        case 1:
                            if (pMoney - 1 >= 0 && shahtaZhelezo == false)
                            {
                                pMoney -= 1;
                                Console.WriteLine("Вы приобрели шахту с железом");
                                shahtaZhelezo = true;
                                Console.WriteLine();
                            }
                            else if (pMoney - 1 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("У вас уже есть эта шахта");
                            }
                            break;
                        case 2:
                            if (pMoney - 2 >= 0 && shahtaDollarbl == false)
                            {
                                pMoney -= 2;
                                Console.WriteLine("Вы приобрели шахту с долларами");
                                shahtaDollarbl = true;
                                Console.WriteLine();
                            }
                            else if (pMoney - 2 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("У вас уже есть эта шахта");
                            }
                            break;
                        case 3:
                            if (pMoney - 3 >= 0 && shahtaZoloto == false)
                            {
                                pMoney -= 3;
                                Console.WriteLine("Вы приобрели шахту с золотом");
                                shahtaZoloto = true;
                                Console.WriteLine();
                            }
                            else if (pMoney - 3 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("У вас уже есть эта шахта");
                            }
                            break;
                        case 4:
                            if (pMoney - 4 >= 0 && shahtaAlmazbl == false)
                            {
                                pMoney -= 4;
                                Console.WriteLine("Вы приобрели шахту с алмазами");
                                shahtaAlmazbl = true;
                                Console.WriteLine();
                            }
                            else if (pMoney - 4 < 0)
                            {
                                Console.WriteLine("У вас мало монет, идите работать!");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("У вас уже есть эта шахта");
                            }
                            break;
                        case 5:
                            break;
                    }
                    break;
                case 4:
                    break;
            }
        }
        private static void Inventar()
        {
            Console.WriteLine("-----Инвентарь-----");
            Console.WriteLine($"1. Лопата - {countLopata}");
            Console.WriteLine($"2. Молоток - {countMolotok}");
            Console.WriteLine($"3. Штыковая лопата - {countSHtlopata}");
            Console.WriteLine($"4. Кирка - {countKirka}");
            Console.WriteLine($"5. Бур - {countByr}");
            Console.WriteLine($"6. Яблоко - {count9bloko}");
            Console.WriteLine($"7. Бургер - {countByrger}");
            Console.WriteLine($"8. Пиво - {countPivo}");
            Console.WriteLine($"9. Меню");
            Console.WriteLine("-------------------");

            Console.WriteLine();
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choise)
            {
                case 1:
                    if (countLopata > 0 && iAccuracy == 0)
                    {
                        pOrydie = "Лопата";
                        countLopata -= 1;
                        Console.WriteLine("Вы взяли лопату");
                    }
                    else if (countLopata == 0)
                    {
                        Console.WriteLine("У вас нет лопаты!");
                    }
                    break;
                case 2:
                    if (countMolotok > 0 && iAccuracy == 0)
                    {
                        pOrydie = "молоток";
                        countMolotok -= 1;
                        Console.WriteLine("Вы взяли молоток");
                    }
                    else if (countMolotok == 0)
                    {
                        Console.WriteLine("У вас нет молотка!");
                    }
                    break;
                case 3:
                    if (countSHtlopata > 0 && iAccuracy == 0)
                    {
                        pOrydie = "Штыковая лопата";
                        countSHtlopata -= 1;
                        Console.WriteLine("Вы взяли штыковую лопату");
                    }
                    else if (countSHtlopata == 0)
                    {
                        Console.WriteLine("У вас нет штыковой лопаты!");
                    }
                    break;
                case 4:
                    if (countKirka > 0 && iAccuracy == 0)
                    {
                        pOrydie = "Кирка";
                        countKirka -= 1;
                        Console.WriteLine("Вы взяли кирку");
                    }
                    else if (countKirka == 0)
                    {
                        Console.WriteLine("У вас нет кирки!");
                    }
                    break;
                case 5:
                    if (countByr > 0)
                    {
                        pOrydie = "Бур";
                        countByr -= 1;
                        Console.WriteLine("Вы взяли бур");
                    }
                    else if (countByr == 0)
                    {
                        Console.WriteLine("У вас нет бура!");
                    }
                    break;
                case 6:
                    if (satiety >= 100)
                    {
                        Console.WriteLine("Вы не голодны");
                    }
                    else if (satiety + Yabloko <= 100 && count9bloko > 0)
                    {
                        Console.WriteLine("Вы съели яблоко");
                        count9bloko -= 1;
                        satiety += Yabloko;
                    }
                    else if (satiety + Yabloko > 100 && count9bloko > 0)
                    {
                        Console.WriteLine("Вы сыты");
                        satiety = 100;
                        count9bloko -= 1;
                    }
                    break;
                case 7:
                    if (satiety >= 100)
                    {
                        Console.WriteLine("Вы не голодны");
                    }
                    else if (satiety + Byrger < 100 && countByrger > 0)
                    {
                        Console.WriteLine("Вы съели бургер");
                        countByrger -= 1;
                        satiety += Byrger;
                    }
                    else if (satiety + Byrger >= 100 && countByrger > 0)
                    {
                        Console.WriteLine("Вы сыты");
                        satiety = 100;
                        countByrger -= 1;
                    }
                    break;
                case 8:
                    if (satiety >= 100)
                    {
                        Console.WriteLine("Вы не голодны");
                    }
                    else if (countPivo > 0)
                    {
                        Console.WriteLine("Вы бахнули пива");
                        countPivo -= 1;
                        satiety = 100;
                    }
                    break;
                case 9:
                    break;
            }
        }
        class Item
        {
            public string Title { get; set; }
            public int iAccuracy { get; set; }
            public int iSpeed { get; set; }


            public Item(string title, int iaccuracy, int ispeed)
            {
                Title = title;
                iAccuracy = iaccuracy;
                iSpeed = ispeed;
            }
        }
        private static void Kopat()
        {

            Random rnd = new Random();
            for (int i = 0; i < iSpeed; i++)
            {
                int r = rnd.Next(26);

                if (r > 0 && iAccuracy > 0)
                {
                    Console.WriteLine("Вы добыли камень");
                    pMoney += 1;
                    pExperience += 1;
                }
                else if (r == 0 && iAccuracy > 0)
                {
                    Console.WriteLine("Вы добыли уголь!");
                    pMoney += 20;
                    pExperience += 10;
                }
                else if (satiety == 0)
                {
                    Console.WriteLine("Вы не можете копать, вы голодны!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("У вас сломался инструмент");
                    Console.WriteLine();
                    break;
                }
            }
            if (satiety > 0 && iAccuracy > 0)
            {
                satiety -= 1;
                iAccuracy -= 1;
            }
        }
        private static void Kopat2()
        {

            Random rnd = new Random();
            for (int i = 0; i < iSpeed; i++)
            {
                int r = rnd.Next(26);

                if (r > 0 && iAccuracy > 0)
                {
                    Console.WriteLine("Вы добыли камень");
                    pMoney += 1;
                    pExperience += 1;
                }
                else if (r == 0 && iAccuracy > 0)
                {
                    r = rnd.Next(3);
                    if (r == 0)
                    {
                        Console.WriteLine("Вы добыли железо!");
                        pMoney += 60;
                        pExperience += 30;
                    }
                    else if (r > 0)
                    {
                        Console.WriteLine("Вы добыли уголь!");
                        pMoney += 20;
                        pExperience += 10;
                    }
                }
                else if (satiety == 0)
                {
                    Console.WriteLine("Вы не можете копать, вы голодны!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("У вас сломался инструмент");
                    Console.WriteLine();
                    break;
                }
            }
            if (satiety > 0 && iAccuracy > 0)
            {
                satiety -= 1;
                iAccuracy -= 1;
            }
        }
        private static void Kopat3()
        {

            Random rnd = new Random();
            for (int i = 0; i < iSpeed; i++)
            {
                int r = rnd.Next(26);

                if (r > 0 && iAccuracy > 0)
                {
                    Console.WriteLine("Вы добыли камень");
                    pMoney += 1;
                    pExperience += 1;
                }
                else if (r == 0 && iAccuracy > 0)
                {
                    r = rnd.Next(5);
                    if (r > 0)
                    {
                        r = rnd.Next(3);
                        if (r == 0)
                        {
                            Console.WriteLine("Вы добыли доллар!");
                            pMoney += 100;
                            pExperience += 100;
                        }
                        else if (r > 0)
                        {
                            Console.WriteLine("Вы добыли железо!");
                            pMoney += 60;
                            pExperience += 20;
                        }
                    }
                    else if (r == 0)
                    {
                        Console.WriteLine("Вы добыли уголь!");
                        pMoney += 20;
                        pExperience += 10;
                    }
                }
                else if (satiety == 0)
                {
                    Console.WriteLine("Вы не можете копать, вы голодны!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("У вас сломался инструмент");
                    Console.WriteLine();
                    break;
                }
            }
            if (satiety > 0 && iAccuracy > 0)
            {
                satiety -= 1;
                iAccuracy -= 1;
            }
        }
        private static void Kopat4()
        {

            Random rnd = new Random();
            for (int i = 0; i < iSpeed; i++)
            {
                int r = rnd.Next(26);

                if (r > 0 && iAccuracy > 0)
                {
                    Console.WriteLine("Вы добыли камень");
                    pMoney += 1;
                    pExperience += 1;
                }
                else if (r == 0 && iAccuracy > 0)
                {
                    r = rnd.Next(5);
                    if (r > 0)
                    {
                        r = rnd.Next(5);
                        if (r > 0)
                        {
                            r = rnd.Next(3);
                            if (r == 0)
                            {
                                Console.WriteLine("Вы добыли доллар!");
                                pMoney += 100;
                                pExperience += 100;
                            }
                            else if (r > 0)
                            {
                                Console.WriteLine("Вы добыли золото!");
                                pMoney += 250;
                                pExperience += 200;
                            }
                        }
                        else if (r == 1)
                        {
                            Console.WriteLine("Вы добыли железо!");
                            pMoney += 60;
                            pExperience += 20;
                        }
                    }
                    else if (r == 0)
                    {
                        Console.WriteLine("Вы добыли уголь!");
                        pMoney += 20;
                        pExperience += 10;
                    }
                }
                else if (satiety == 0)
                {
                    Console.WriteLine("Вы не можете копать, вы голодны!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("У вас сломался инструмент");
                    Console.WriteLine();
                    break;
                }
            }
            if (satiety > 0 && iAccuracy > 0)
            {
                satiety -= 1;
                iAccuracy -= 1;
            }
        }
        private static void Kopat5()
        {

            Random rnd = new Random();
            for (int i = 0; i < iSpeed; i++)
            {
                int r = rnd.Next(26);

                if (r > 0 && iAccuracy > 0)
                {
                    Console.WriteLine("Вы добыли камень");
                    pMoney += 1;
                    pExperience += 1;
                }
                else if (r == 0 && iAccuracy > 0)
                {
                    r = rnd.Next(5);
                    if (r > 0)
                    {
                        r = rnd.Next(5);
                        if (r > 0)
                        {
                            r = rnd.Next(5);
                            if (r == 0)
                            {
                                Console.WriteLine("Вы добыли доллар!");
                                pMoney += 100;
                                pExperience += 100;
                            }
                            else if (r > 0)
                            {
                                r = rnd.Next(3);
                                if (r == 0)
                                {
                                    Console.WriteLine("Вы добыли золото!");
                                    pMoney += 250;
                                    pExperience += 200;
                                }
                                else if (r > 0)
                                {
                                    Console.WriteLine("Вы добыли АЛМАЗ!");
                                    pMoney += 500;
                                    pExperience += 500;
                                }
                            }
                        }
                        else if (r == 1)
                        {
                            Console.WriteLine("Вы добыли железо!");
                            pMoney += 60;
                            pExperience += 20;
                        }
                    }
                    else if (r == 0)
                    {
                        Console.WriteLine("Вы добыли уголь!");
                        pMoney += 20;
                        pExperience += 10;
                    }
                }
                else if (satiety == 0)
                {
                    Console.WriteLine("Вы не можете копать, вы голодны!");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("У вас сломался инструмент");
                    Console.WriteLine();
                    break;
                }
            }
            if (satiety > 0 && iAccuracy > 0)
            {
                satiety -= 1;
                iAccuracy -= 1;
            }
        }
        private static void SaveGame()
        {
            // Создание файла сохранения
            using (StreamWriter writer = new StreamWriter(saveFileName))
            {

                writer.WriteLine(pName);
                writer.WriteLine(pOrydie);
                writer.WriteLine(iSpeed);
                writer.WriteLine(iAccuracy);
                writer.WriteLine(pExperience);
                writer.WriteLine(pMoney);
                writer.WriteLine(satiety);
                writer.WriteLine(countLopata);
                writer.WriteLine(countMolotok);
                writer.WriteLine(countSHtlopata);
                writer.WriteLine(countKirka);
                writer.WriteLine(countByr);
                writer.WriteLine(count9bloko);
                writer.WriteLine(countByrger);
                writer.WriteLine(countPivo);
                writer.WriteLine(shahtaNach);
                writer.WriteLine(shahtaZhelezo);
                writer.WriteLine(shahtaDollarbl);
                writer.WriteLine(shahtaZoloto);
                writer.WriteLine(shahtaAlmazbl);
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
                    pName = reader.ReadLine();
                    pOrydie = reader.ReadLine();
                    iSpeed = int.Parse(reader.ReadLine());
                    iAccuracy = int.Parse(reader.ReadLine());
                    pExperience = int.Parse(reader.ReadLine());
                    pMoney = int.Parse(reader.ReadLine());
                    satiety = int.Parse(reader.ReadLine());
                    countLopata = int.Parse(reader.ReadLine());
                    countMolotok = int.Parse(reader.ReadLine());
                    countSHtlopata = int.Parse(reader.ReadLine());
                    countKirka = int.Parse(reader.ReadLine());
                    countByr = int.Parse(reader.ReadLine());
                    count9bloko = int.Parse(reader.ReadLine());
                    countByrger = int.Parse(reader.ReadLine());
                    countPivo = int.Parse(reader.ReadLine());
                    shahtaNach = bool.Parse(reader.ReadLine());
                    shahtaZhelezo = bool.Parse(reader.ReadLine());
                    shahtaDollarbl = bool.Parse(reader.ReadLine());
                    shahtaZoloto = bool.Parse(reader.ReadLine());
                    shahtaAlmazbl = bool.Parse(reader.ReadLine());
                }

                Console.WriteLine("Игра загружена.");
            }
            else
            {
                Console.WriteLine("Файл сохранения не найден.");
            }
        }
        private static void Game()
        {
            while (true)
            {
                Item lopata = new Item("Лопата", 50, 1);
                Item molotok = new Item("Молоток", 25, 2);
                Item shtLopata = new Item("Штыковая лопата", 75, 3);
                Item kirka = new Item("кирка", 200, 4);
                Item byr = new Item("бур", 5, 30);

                //Выбранная шахта
                Console.WriteLine($"Вы в локации - {choiseShahta}");

                if (choiseShahta == "Дом")
                {
                    // Вывод информации об игроке
                    Console.WriteLine($"Опыт: {pExperience}");
                    Console.WriteLine($"Монеты: {pMoney}");
                    Console.WriteLine($"Голод: {satiety}");
                    Console.WriteLine();
                    // Вывод доступных действий
                    Console.WriteLine("-------Меню-------");
                    Console.WriteLine("1. Выбор шахты");
                    Console.WriteLine("2. Магазин");
                    Console.WriteLine("3. Инвентарь");
                    Console.WriteLine("4. Исследовать");
                    Console.WriteLine("5. Сохранить игру");
                    Console.WriteLine("6. Загрузить игру");
                    Console.WriteLine("7. Выход");
                    Console.WriteLine("------------------");
                    Console.WriteLine();

                    //Выбор
                    int choise = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choise)
                    {
                        case 1:
                            Shahtbl();
                            break;

                        case 2:
                            Magazin();
                            break;
                        case 3:
                            Inventar();
                            switch (pOrydie)
                            {
                                case "Лопата":
                                    iAccuracy = lopata.iAccuracy;
                                    iSpeed = lopata.iSpeed;
                                    break;
                                case "Молоток":
                                    iAccuracy = molotok.iAccuracy;
                                    iSpeed = molotok.iSpeed;
                                    break;
                                case "Штыковая лопата":
                                    iAccuracy = shtLopata.iAccuracy;
                                    iSpeed = shtLopata.iSpeed;
                                    break;
                                case "Кирка":
                                    iAccuracy = kirka.iAccuracy;
                                    iSpeed = kirka.iSpeed;
                                    break;
                                case "Бур":
                                    iAccuracy = byr.iAccuracy;
                                    iSpeed = byr.iSpeed;
                                    break;
                            }
                            break;
                        case 4:
                            break;
                        case 5:
                            SaveGame();
                            break;
                        case 6:
                            LoadGame();
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Я вас не понял!");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine($"Инструмент: {pOrydie}");
                    Console.WriteLine($"Скорость копания: {iSpeed}");
                    Console.WriteLine($"Прочность инструмента: {iAccuracy}");
                    Console.WriteLine();

                    Console.WriteLine($"Опыт: {pExperience}");
                    Console.WriteLine($"Монеты: {pMoney}");
                    Console.WriteLine($"Голод: {satiety}");
                    Console.WriteLine();
                    Console.WriteLine("------Действия------");
                    Console.WriteLine("1. Копать");
                    Console.WriteLine("2. Еда");
                    Console.WriteLine("3. Домой");
                    Console.WriteLine("--------------------");

                    Console.WriteLine();
                    int choise = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (choise)
                    {
                        case 1:
                            if (choiseShahta == "Начальная шахта")
                            {
                                Kopat();
                            }
                            else if (choiseShahta == "Шахта с железом")
                            {
                                Kopat2();
                            }
                            else if (choiseShahta == "Шахта с долларами")
                            {
                                Kopat3();
                            }
                            else if (choiseShahta == "Шахта с золотом")
                            {
                                Kopat4();
                            }
                            else if (choiseShahta == "Шахта с алмазами")
                            {
                                Kopat5();
                            }
                            break;

                        case 2:
                            Inventar();
                            break;
                        case 3:
                            choiseShahta = "Дом";
                            break;
                    }
                }
            }
        }
    }
}