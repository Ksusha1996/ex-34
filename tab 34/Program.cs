//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



using System;

class Program
{
    static void Main(string[] args)
    {
        const int arraySize = 4;
        int[] array = new int[arraySize];

        // Заполнение массива случайными положительными трёхзначными числами
        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Подсчёт количества чётных чисел в массиве
        int count = 0;
        for (int i = 0; i < arraySize; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чётных чисел в массиве: " + count);
        Console.ReadLine();
    }
}
