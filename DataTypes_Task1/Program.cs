using System.Text;

class Program
{
    /// <summary>
    /// Валидирует входные данные.
    /// На вход принимает начальный вклад, количество лет, годовую процентную ставку.
    /// </summary>
    /// <returns>строку.</returns>
    static string ValidateInputData(double initialDeposit, int years, double interestRate)
    {
        StringBuilder stringBuilder = new StringBuilder();

        // Проверка начального вклада.
        if (initialDeposit <= 0)
        {
            stringBuilder.Append($"Ошибка. Начальный вклад (initialDeposit) должен быть положительным числом. Получено: {initialDeposit}.\n");
        }

        // Проверка количества лет.
        if (years <= 0)
        {
            stringBuilder.Append($"Ошибка. Количество лет (years) должно быть положительным числом. Получено: {years}.\n");
        }

        // Проврка годовой процентной ставки.
        if (interestRate <= 0)
        {
            stringBuilder.Append($"Ошибка. Годовая процентная ставка (interestRate) должна быть положительная. Получено: {interestRate}.\n");
        }

        return stringBuilder.ToString();
    }

    /// <summary>
    /// Расчитывает сложный процент для одного года по формуле:
    /// S = P * (1 + r/100)^t
    /// где P - это начальный вклад, r - годовая процентная ставка, t - количество лет. 
    /// </summary>
    /// <returns>число.</returns> 
    static double CalculateAmountForYear(double initialDeposit, int year, double interestRate)
    {
        return initialDeposit * Math.Pow((1 + (interestRate / 100.0)), year);
    }

    /// <summary>
    /// Формирует строку с расчетом сложных процентов по годам.
    /// </summary>
    /// <returns>строку.</returns>
    static string GetCompoundInterest(double initialDeposit, int years, double interestRate)
    {
        string validationErrors = ValidateInputData(initialDeposit, years, interestRate);

        // Если нашлись ошибки при валадации, то эти ошибки возвращаются.
        if (!string.IsNullOrEmpty(validationErrors))
        {
            return validationErrors;
        }

        // Если ошибок нет, то формируется и возвращается итоговая строка.
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 1; i <= years; i++)
        {
            double amount = CalculateAmountForYear(initialDeposit, i, interestRate);

            stringBuilder.Append($"Год {i}: {amount:F2} руб.\n");
        }

        return stringBuilder.ToString();
    }

    /// <summary>
    /// Главная функция.
    /// </summary>
    static void Main()
    {
        // Тест 1. Входные данные равны нулю.
        Console.WriteLine(GetCompoundInterest(0, 0, 0));

        // Тест 2. Входные данные корректны. 
        Console.WriteLine(GetCompoundInterest(1000, 3, 10));
    }
}