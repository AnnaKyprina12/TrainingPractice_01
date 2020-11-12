using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Labirint
{
    class Program
    {
        static int position1 = 0;
        static int position2 = 0;
        static int step = 0;
        static int Key = 0;

        static public char[,] ReadMap()
        {
            string[] file = File.ReadAllLines("map.txt");
            char[,] map = new char[file.Length, file[0].Length];


            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    map[i, j] = file[j][i];

                    if (map[i, j] == '.')
                    {
                        position1 = i;
                        position2 = j;
                    }
                }
            }

            return map;
        }

        static public void DrawMap(char[,] map)
        {
            Console.Clear();
            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int i = 0; i < map.GetLength(1); i++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static public bool CheckStep(char[,] map, int position1, int position2)
        {
            switch (map[position1, position2])
            {
                case ' ':
                    step++;
                    Console.SetCursorPosition(17, 7);
                    Console.WriteLine($"Сделано " + step + " шагов");
                    return true;

                case '-':
                    Key++;
                    step++;
                    Console.SetCursorPosition(17, 7);
                    Console.WriteLine($"Сделано " + step + " шагов");
                    Console.SetCursorPosition(17, 8);
                    if  (Key > 0)
                        Console.WriteLine($"Вы собрали " + Key + " ключей");
                    Console.SetCursorPosition(position1, position2);
                    map[position1, position2] = ' ';
                    Console.Write(map[position1, position2]);
                    return true;

                case '■':
                    step++;
                    Console.SetCursorPosition(17, 7);
                    Console.WriteLine($"Сделано " + step + " шагов");
                    return true;

                case '+':
                    if (Key == 2)
                    {
                        Console.SetCursorPosition(position1, position2);
                        map[position1, position2] = ' ';
                        Console.Write(map[position1, position2]);
                        Console.SetCursorPosition(17, 10);
                        Console.WriteLine($"Лабиринт пройден! Вы сделали " + step + " шагов и собрали все ключи");
                        Console.SetCursorPosition(17, 30);
                        System.Environment.Exit(1);
                    }
                    return false;
                default:
                    return false;
            }
        }

        static public void MoveMap(char[,] map, int position1, int position2)
        {
            int newPos;
            Console.SetCursorPosition(17, 1);
            Console.WriteLine("Правила игры: Соберите все 2 ключа на карте, они отмечены (-) ");
            Console.SetCursorPosition(17, 3);
            Console.WriteLine($"Для выхода нажмите Esc");
            Console.SetCursorPosition(position1, position2);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.LeftArrow:
                    newPos = position1 - 1;
                    if (CheckStep(map, newPos, position2))
                        position1 = newPos;
                    break;
                case ConsoleKey.RightArrow:
                    newPos = position1 + 1;
                    if (CheckStep(map, newPos, position2))
                        position1 = newPos;
                    break;
                case ConsoleKey.UpArrow:
                    newPos = position2 - 1;
                    if (CheckStep(map, position1, newPos))
                        position2 = newPos;
                    break;
                case ConsoleKey.DownArrow:
                    newPos = position2 + 1;
                    if (CheckStep(map, position1, newPos))
                        position2 = newPos;
                    break;
                case ConsoleKey.Escape:
                    Console.SetCursorPosition(17, 10);
                    Console.WriteLine($"Вы вышли из игры");
                    Console.SetCursorPosition(17, 30);
                    System.Environment.Exit(1);
                    break;
            }
            Console.SetCursorPosition(position1, position2);
            MoveMap(map, position1, position2);
        }
            static void Main(string[] args)
        {
            char[,] map = ReadMap();
            DrawMap(map);
            Console.SetCursorPosition(position1, position2);
            MoveMap(map, position1, position2);

            Console.ReadKey();
        }
    }
}
