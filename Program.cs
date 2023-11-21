
   
    
        string[] inputArray;

        
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
                inputArray = EnterArrayFromConsole();
                break;
            case 2:
                inputArray = new string[] { "mather", "good", "cat", "dog", "mouse", "fox" }; 
                break;
            default:
                Console.WriteLine("Некорректный выбор.");
                return;
        }

        string[] filteredArray = FilterStrings(inputArray);

        Console.WriteLine("\nОтфильтрованный массив:");
        foreach (string str in filteredArray)
        {
            Console.WriteLine(str);
        }
    

    static string[] EnterArrayFromConsole()
    {
        Console.Write("Введите размер массива строк: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0 || size >= 11)
        {
            Console.WriteLine("Некорректный ввод размера массива. Введите от 1 до 10");
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

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];

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

