using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task1
{
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        /// <summary>
        /// Создает прямоугольник с указанными координатами и размером.
        /// </summary>
        /// <param name="x">Координата X левой вершины.</param>
        /// <param name="y">Координата Y левой вершины.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть больше нуля.</param>
        /// <param name="height">Высота прямоугольника. Должна быть больше нуля.</param>
        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = ValidateSide(width, "Ширина");
            Height = ValidateSide(height, "Высота");
        }

        // Проверка значения стороны прямоугольника.
        private static int ValidateSide(int value, string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException($"{parameterName} должна быть положительным числом.");
            }

            return value;
        }

        // Расчет периметра прямоугольника.
        public int CalculatePerimeter()
        {
            return (Width + Height) * 2;
        }

        // Расчет площади прямоугольника.
        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
