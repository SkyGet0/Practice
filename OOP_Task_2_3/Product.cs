using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task_2_3
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public decimal Price { get; private set; }
        public DateTime ProductionDate { get; set; }
        public TimeSpan ProductLifePeriod { get; set; }
        public DateTime ExpirationDate
        {
            get => ProductionDate + ProductLifePeriod;
        }

        /// <summary>
        /// Создает товар.
        /// </summary>
        /// <param name="name">Наименование товара.</param>
        /// <param name="manufacturer">Производитель товара.</param>
        /// <param name="price">Цена товара.</param>
        /// <param name="productionDate">Дата производства.</param>
        /// <param name="productLifePeriod">Срок годности (дней).</param>
        public Product(string name, string manufacturer, decimal price, DateTime productionDate, TimeSpan productLifePeriod)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = ValidatePrice(price);
            ProductionDate = productionDate;
            ProductLifePeriod = productLifePeriod;
        }

        // Проверка значения цены товара.
        private static decimal ValidatePrice(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Цена не может быть отрицательной.");
            }
            return price;
        }

        // Вывод информации о товаре.
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Информация о продукте {this.Name}.");
            stringBuilder.AppendLine($"Производитель: {Manufacturer}.");
            stringBuilder.AppendLine($"Цена: {Price:F2} руб.");
            stringBuilder.AppendLine($"Дата производства: {ProductionDate:d}.");
            stringBuilder.AppendLine($"Срок годности: до {ExpirationDate:d}.");

            return stringBuilder.ToString();
        }
    }
}
