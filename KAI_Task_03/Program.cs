using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string secret = "Секретное слово";
            string pass = "1234";
            string vvod;
            int mistake = 3;
            while (mistake != 0)//счетчик ошибок
            {
                Console.WriteLine("Введите пароль:");
                vvod = Console.ReadLine();//ввод пароля
                if (vvod == pass)//если пароль совпал, выводит секретное слово
                    Console.WriteLine(secret);
                else//если пароль не совпал, показывает, сколько осталось попыток
                {
                    mistake--;
                    Console.WriteLine("Пароль введён неверно, осталось " + mistake + " попытки/попыток");
                }
            }
        }
    }
}
