using System;

namespace KAI_Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] fio = new string[3][];
            fio[0] = new string[50];
            fio[1] = new string[50];
            fio[2] = new string[50];
            string[] dolzh = new string[50];
            int value = 0;
            int number;
            Menu:
            Console.WriteLine("Что вы хотите сделать:");
            Console.WriteLine("1. Добавить запись");
            Console.WriteLine("2. Вывести все записи");
            Console.WriteLine("3. Удалить запись");
            Console.WriteLine("4. Поиск записи по фамилии");
            Console.WriteLine("5. Выход");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write("Введите Фамилию: ");
                    fio[0][value] = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Введите Имя: ");
                    fio[1][value] = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Введите Отчество: ");
                    fio[2][value] = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Введите Должность: ");
                    dolzh[value] = Console.ReadLine();
                    Console.Clear();
                    value++;
                    Console.WriteLine("Данные записаны успешно");
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;

                case ConsoleKey.D2:
                    Console.Clear();
                    if (value != 0)
                    {
                        for (int i = 0; i <= value - 1; i++)
                            Console.WriteLine(i + ". " + fio[0][i] + " " + fio[1][i] + " " + fio[2][i] + " : " + dolzh[i]);
                        Console.WriteLine();
                        Console.WriteLine("Нажмите любую кнопку что-бы продолжить ");
                        Console.ReadKey();
                        Console.Clear();
                        goto Menu;
                    }
                    break;

                case ConsoleKey.D3:
                    Console.Clear();
                    Console.WriteLine("Под каким номер будет удалена запись? ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number >= 0 && number <= value)
                    {
                        for (int i = 0; i <= value; i++)
                        {
                            if (i == number)
                            {
                                if (i != value - 1)
                                {
                                    fio[0][i] = fio[0][i + 1];
                                    fio[1][i] = fio[1][i + 1];
                                    fio[2][i] = fio[2][i + 1];
                                    dolzh[i] = dolzh[i + 1];
                                }
                                else
                                {
                                    fio[0][i] = "";
                                    fio[1][i] = "";
                                    fio[2][i] = "";
                                    dolzh[i] = "";
                                }
                            }
                        }
                        value--;
                        Console.Clear();
                        Console.WriteLine("Запись удалена");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Такого номера нет");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    goto Menu;

                case ConsoleKey.D4:
                    Console.Clear();
                    Console.Write("Введите фамилию: ");
                    bool Sovpad = false;
                    string fam = Console.ReadLine();
                    for (int i = 0; i <= value; i++)
                    {
                        if (fam == fio[0][i])
                        {
                            Sovpad = true;
                            Console.WriteLine(i + ". " + fio[0][i] + " " + fio[1][i] + " " + fio[2][i] + " : " + dolzh[i]);
                        }
                    }
                    if (!Sovpad)
                    {
                        Console.WriteLine("Такой фамилии нет");
                    }
                    Console.WriteLine("Нажмите любую кнопку чтобы продолжить");
                    Console.ReadKey();
                    Console.Clear();
                    goto Menu;

                case ConsoleKey.D5:
                    Console.Clear();
                    System.Environment.Exit(1);
                    break;
            }

        }
    }
}
