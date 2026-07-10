using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task_2_3
{
    public class DiscountedProduct : Product
    {
        public decimal DiscountPercent { get; private set; }
        public decimal SalePrice { get; private set; }

        
        public DiscountedProduct(string name, string manufacturer, decimal price, DateTime productionDate, TimeSpan productLifePeriod)
            : base(name, manufacturer, price, productionDate, productLifePeriod)
        {
        }

        // Конструктор копирования.
        public DiscountedProduct(Product product)
            : base(product.Name, product.Manufacturer, product.Price, product.ProductionDate, product.ProductLifePeriod)
        {
        }

        // Применяет скидку к цене товара.
        public void ApplyDiscount(decimal discountPercent)
        {
            if (discountPercent < 0 || discountPercent > 100)
            {
                throw new ArgumentOutOfRangeException("Процент скидки должен быть в диапазоне от 0 до 100.");
            }

            DiscountPercent = discountPercent;
            SalePrice = Price * (1 - discountPercent / 100m);
        }
        
        // Вывод информации о товаре со скидкой.
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Информация о продукте со скидкой: {this.Name}.");
            stringBuilder.AppendLine($"Производитель: {Manufacturer}.");
            stringBuilder.AppendLine($"Цена: {Price:F2} руб.");
            stringBuilder.AppendLine($"Размер скидки: {DiscountPercent}%.");
            stringBuilder.AppendLine($"Цена с учетом скидки: {SalePrice} руб.");
            stringBuilder.AppendLine($"Дата производства: {ProductionDate:d}.");
            stringBuilder.AppendLine($"Срок годности: до {ExpirationDate:d}.");
            
            return stringBuilder.ToString();
        }
    }
}
