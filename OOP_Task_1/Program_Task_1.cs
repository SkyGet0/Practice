using OOP_Task1;

class Program_Task_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Создаем прямоугольник.");

        int x = ReadIntValue("Введите координату X: ");
        int y = ReadIntValue("Введите координату Y: ");
        int width = ReadIntValue("Введите ширину: ");
        int height = ReadIntValue("Введите высоту: ");

        Console.WriteLine();

        try
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            Console.WriteLine($"Создан прямоугольнк: {nameof(rectangle)}.");
            Console.WriteLine($"Координаты левой верхней вершины: ({rectangle.X}, {rectangle.Y}).");
            Console.WriteLine($"Высота = {rectangle.Height}. Ширина = {rectangle.Width}.");
            Console.WriteLine($"Площадь {nameof(rectangle)} равна {rectangle.CalculateArea()}.");
            Console.WriteLine($"Периметр {nameof(rectangle)} равен {rectangle.CalculatePerimeter()}.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Ошибка." + ex.Message);
        }
    }

    static int ReadIntValue(string prompt)
    {
        int value;
        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out value));

        return value;
    }
}