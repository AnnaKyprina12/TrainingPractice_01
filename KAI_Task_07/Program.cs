using System;

namespace KAI_Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int razm = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[razm];
            Random random = new Random();
            for (int i = 0; i < razm; i++) mass[i] = random.Next(-100, 100);
            Console.WriteLine("До перемешивания");
            for (int i = 0; i < razm; i++)
                Console.Write(mass[i] + " ");
            Console.WriteLine();
            Shuffle(mass, razm);
            Console.WriteLine("После перемешивания:");
            for (int i = 0; i < razm; i++)
                Console.Write(mass[i] + " ");
            Console.WriteLine();
        }
        static void Shuffle(int[] array, int size)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                int j = random.Next(0, i + 1);
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
