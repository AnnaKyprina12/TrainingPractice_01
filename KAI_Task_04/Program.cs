using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hpboss = 1000;//здоровье босса
            int hpplayer = 500;//здоровье игрока
            int hod;
            int open = 0;//открытие двух способностей
            int period = 0;//периодический урон
            while ((hpboss > 0) && (hpplayer > 0))
            {
                Console.WriteLine("HP Босса:" + hpboss);
                Console.WriteLine("HP Игрока:" + hpplayer);
                Console.WriteLine();
                Console.WriteLine("Список способностей:");
                Console.WriteLine("1.Скрыть присутствие(Босс теряет игрока из виду, и пропускает ход)");
                Console.WriteLine("2.Перевязать раны(Восстанавливает 150 ед. здоровья игроку, действует на следующий ход после 'Скрыть присутствие')");
                Console.WriteLine("3.Удар со спины(Наносит 400 ед. урона, действует на следующий ход после 'Скрыть присутствие')");
                Console.WriteLine("4.Обычный удар(Наносит 100 ед. урона)");
                Console.WriteLine("5.Сильный удар(Наносит 200 ед. урона)");
                Console.WriteLine("6.Ядовитый клинок (Наносит 100 ед. урона и накладывает 20 периодического урона на 4 хода)");
                Console.WriteLine("7.Контракт на крови(Наносит 250 ед. урона, но взамен отнимает 150 ед. здоровья у игрока)");
                Console.WriteLine();
                Console.WriteLine("Какую способность вы хотите использовать?");
                hod = Convert.ToInt32(Console.ReadLine());//Выбор способности
                switch (hod)
                {
                    case 1://Скрыть присутствие
                        if (period != 0)
                        {
                            hpboss = hpboss - 50;
                            period--;
                        }
                        open = 1;
                        break;

                    case 2://Перевязать раны
                        if (open == 1)
                        {
                            if (period != 0)
                            {
                                hpboss = hpboss - 50;
                                period--;
                            }
                            hpplayer = hpplayer + 150;
                            open--;
                        }
                        else
                        {
                            Console.WriteLine("Чтобы использовать эту способность, скройте своё присутствие");
                            hod = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 3://Удар со спины
                        if (open == 1)
                        {
                            if (period != 0)
                            {
                                hpboss = hpboss - 50;
                                period--;
                            }
                            hpboss = hpboss - 400;
                            open--;
                        }
                        else
                        {
                            Console.WriteLine("Чтобы использовать эту способность, скройте своё присутствие");
                            hod = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    case 4://Обычный удар
                        if (period != 0)
                        {
                            hpboss = hpboss - 50;
                            period--;
                        }
                        hpboss = hpboss - 100;
                        hpplayer = hpplayer - 50;
                        break;

                    case 5://Сильный удар
                        hpboss = hpboss - 200;
                        if (period != 0)
                        {
                            hpboss = hpboss - 50;
                            period--;
                        }
                        hpplayer = hpplayer - 50;

                        break;

                    case 6://Ядовитый клинок
                        hpboss = hpboss - 100;
                        period = 4;
                        hpplayer = hpplayer - 50;
                        break;

                    case 7://Контракт на крови
                        if (period != 0)
                        {
                            hpboss = hpboss - 50;
                            period--;
                        }
                        hpboss = hpboss - 250;
                        hpplayer = hpplayer - 150;
                        hpplayer = hpplayer - 50;
                        break;
                }
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Игра окончена");
        }
    }
}
