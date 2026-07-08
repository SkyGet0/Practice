class Task2
{
    /// <summary>
    /// Проверяет высоту ромба. Высота должна быть целым, нечетным и положительным числом.
    /// </summary>
    /// <param name="height">Значение высоты.</param>
    /// <param name="errorMessage">Сообщение об ошибке.</param>
    /// <returns>true или false.</returns>
    static bool IsValidHeight(int height, out string errorMessage)
    { 
        if (height <= 0)
        {
            errorMessage = $"Ошибка. Высота должна быть положительной. Получено {height}.\n";
            return false;
        }
        
        if (height % 2 == 0)
        {
            errorMessage = $"Ошибка. Высота должна быть нечетной. Получено {height}.\n";
            return false;
        }

        errorMessage = string.Empty;
        return true;
    }

    /// <summary>
    /// Рисует ромб.
    /// </summary>
    /// <param name="height">Высота ромба.</param>
    static void DrawRhomb(int height)
    {
        // Расстояние от верха до середины ромба.
        int middle = height / 2;

        for (int i = 0; i < height; i++)
        {
            // Количество пробелов в текущей строке.
            int spaces = Math.Abs(middle - i);

            // Количество символов (X) в текущей строке.
            // Количество пробелов умножаетя на 2, т.к. столько же пробелов есть и с обратной стороны.
            int symbols = height - spaces * 2;

            Console.Write(new string(' ', spaces));

            if (symbols == 1)
            {
                Console.WriteLine("X");
            }
            else
            {
                Console.Write("X");
                Console.Write(new string (' ', symbols - 2));
                Console.WriteLine("X");
            }
        }
    }

    /// <summary>
    /// Главная функция.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите высоту ромба: ");
        string? input = Console.ReadLine();

        int N;
        bool validInput = int.TryParse(input, out N);

        Console.WriteLine();

        // Проверка значения высоты.
        if (!validInput)
        {
            Console.WriteLine("Ошибка преобразования. Высота должна быть числом.");
            return;
        }

        if (!IsValidHeight(N, out string error))
        {
            Console.WriteLine(error);
            return;
        }

        // Отрисовка ромба.
        DrawRhomb(N);
    }
}