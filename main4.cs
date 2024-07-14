using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
        {
            int[] array = new int[size];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    array[i] = element;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                    i--; 
                }
            }

            int indexOfMax = FindIndexOfMax(array);

            Console.WriteLine($"Индекс первого наибольшего числа в массиве: {indexOfMax}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод размера массива.");
        }
    }

    static int FindIndexOfMax(int[] array)
    {
        int indexOfMax = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[indexOfMax])
            {
                indexOfMax = i;
            }
        }

        return indexOfMax;
    }
}
