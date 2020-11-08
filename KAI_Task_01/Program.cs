using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold, crystal;
            int price = 10;
            Console.WriteLine("Сколько у вас золота?");
            Console.Write("Введите количества золота: ");
            gold = Convert.ToInt32(Console.ReadLine());//ввод количества золота
            Console.WriteLine();
            Console.WriteLine("Сколько кристаллов вы хотите купить?(стоимость 1-го кристалла-" + price + " gold)");
            Console.Write("Введите количества кристаллов: ");
            crystal = Convert.ToInt32(Console.ReadLine());//ввод количества кристалов
            Console.WriteLine();

            while (gold - crystal * price >= 0)//проверяет, хватает ли золота
            {
                Console.WriteLine("Осталось " + (gold - crystal * price) + " золота, было куплено " + crystal + " кристаллов");
                break;
            }
            while (gold - crystal * price < 0)//проверяет, хватает ли золота
            {
                Console.WriteLine("Операция не может быть выполнена, у вас всего " + gold + " золота");
                break;
            }
        }
    }
}
