using OOP_Task_2_3;
using System.Runtime.Intrinsics.Arm;
class Program
{
    static void Main()
    {
        // Ввод данных для товара без скидки.
        Console.Write("Введите наименование товара: ");
        string name = Console.ReadLine() ?? "Товар";

        Console.Write("Введите производителя товара: ");
        string? manufacturer = Console.ReadLine() ?? "Производитель";

        decimal price = ReadDecimalValue("Введите цену товара: ");

        DateTime productionDate = ReadDateTimeValue("Введите дату производства товара (день.месяц.год): ");
        
        int days = ReadIntValue("Введите срок годности товара (дней): ");

        Console.WriteLine();

        // Создание товара без скидки.
        Product product = new Product(name, manufacturer, price, productionDate, TimeSpan.FromDays(days));
        Console.WriteLine(product.ToString());

        // Создание товара со скидкой через конструктор копирования.
        DiscountedProduct discountedProduct = new DiscountedProduct(product);
        discountedProduct.ApplyDiscount(20);
        Console.WriteLine(discountedProduct.ToString());
    }

    static decimal ReadDecimalValue(string prompt)
    {
        decimal value;
        do
        {
            Console.Write(prompt);
        } while (!decimal.TryParse(Console.ReadLine(), out value));

        return value;
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

    static DateTime ReadDateTimeValue(string prompt)
    {
        DateTime dateTime;
        do
        {
            Console.Write(prompt);
        } while (!DateTime.TryParse(Console.ReadLine(), out dateTime));

        return dateTime;
    }
}