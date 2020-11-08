using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();//ввод текста
            while (text != "exit")//пока не будет введено слово "exit", продолжать писать
            {
                Console.WriteLine("");//пропустить строчку
                text = Console.ReadLine();//ввод текста
            }
        }
    }
}
