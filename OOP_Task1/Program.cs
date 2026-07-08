using OOP_Task1;

class Program
{
    static void Main(string[] args)
    {
        // Прямоугольник с верными данными.
        Rectangle rectangle = new Rectangle(0, 0, 10, 5);

        // Прямоугольник с неверными данными. Должно выбросить исключение.
        // Rectangle rectangle2 = new Rectangle(0, 0, 0, 5);
        // Console.WriteLine(rectangle2.CalculateArea());

        Console.WriteLine($"Создан прямоугольнк: {nameof(rectangle)}.");
        Console.WriteLine($"Координаты левой верхней вершины: ({rectangle.X}, {rectangle.Y}).");
        Console.WriteLine($"Высота = {rectangle.Height}. Ширина = {rectangle.Width}.");
        Console.WriteLine($"Площадь {nameof(rectangle)} равна {rectangle.CalculateArea()}.");
        Console.WriteLine($"Периметр {nameof(rectangle)} равен {rectangle.CalculatePerimeter()}.");
    }
}