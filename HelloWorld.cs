using System;

class Program
{
    static void Main()
    {
        // Создаём массив (можно ввести вручную или задать случайно)
        int[] array = { 5, 3, 8, 1, 9, 2, 7, 4, 6 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Сортировка пузырьком
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Меняем элементы местами
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Отсортированный массив:");
        PrintArray(array);

        Console.ReadKey();
    }

    // Вспомогательный метод для вывода массива
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}