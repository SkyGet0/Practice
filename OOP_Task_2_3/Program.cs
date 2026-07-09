using OOP_Task_2_3;
class Program
{
    static void Main()
    {
        // ¬вод данных дл€ товара.
        Console.Write("¬ведите наименование товара: ");
        string name = Console.ReadLine() ?? "“овар";

        Console.Write("¬ведите производител€ товара: ");
        string? manufacturer = Console.ReadLine() ?? "ѕроизводитель";

        decimal price = ReadDecimalValue("¬ведите цену товара: ");

        DateTime productionDate = ReadDateTimeValue("¬ведите дату производства товара (день.мес€ц.год): ");

        DateTime expirationDate = ReadDateTimeValue("¬ведите срок годности товара (день.мес€ц.год): ");

        Console.WriteLine();

        // —оздание товара.
        Product product = new Product(name, manufacturer, price, productionDate, expirationDate);
        Console.WriteLine(product.ToString());
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