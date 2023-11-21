using System;

class Program
{
    static void Main()
    {
        string[] inputArray;

        // Выбор способа задания массива (с клавиатуры или на старте программы)
        Console.WriteLine("Выберите способ задания массива:");
        Console.WriteLine("1. Ввести с клавиатуры");
        Console.WriteLine("2. Задать на старте программы");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Некорректный выбор.");
            return;
        }

        switch (choice)
        {
            case 1:
                // Ввод массива с клавиатуры
                inputArray = EnterArrayFromConsole();
                break;
            case 2:
                // Задание массива на старте программы
                inputArray = new string[] { "apple", "banana", "cat", "dog", "elephant", "fox" }; // Измените массив по своему усмотрению
                break;
            default:
                Console.WriteLine("Некорректный выбор.");
                return;
        }

        // Фильтрация массива строк
        string[] filteredArray = FilterStrings(inputArray);

        // Вывод отфильтрованного массива
        Console.WriteLine("\nОтфильтрованный массив:");
        foreach (string str in filteredArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] EnterArrayFromConsole()
    {
        Console.Write("Введите размер массива строк: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Некорректный ввод размера массива.");
            Environment.Exit(0);
        }

        string[] inputArray = new string[size];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }

        return inputArray;
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;

        // Подсчет количества строк, удовлетворяющих условию
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива нужного размера
        string[] filteredArray = new string[count];

        // Заполнение нового массива строками, удовлетворяющими условию
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                filteredArray[index] = str;
                index++;
            }
        }

        return filteredArray;
    }
}
