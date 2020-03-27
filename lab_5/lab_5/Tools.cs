using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    /// <summary>
    /// Класс конечных деталей
    /// </summary>
    class Tools : Equipment
    {
        /// <summary>
        /// Конструктор класс
        /// </summary>
        /// <param name="name">Имя объекта</param>
        /// <param name="cost">Цена объекта</param>
        public Tools(string name, int cost) : base(name, cost) { }

        /// <summary>
        /// Метод для вывода стоимости простого объекта
        /// </summary>
        /// <returns>Цена объекта</returns>
        public override int DisplayCost() { return cost; }

        /// <summary>
        /// Метод для вывода объекта
        /// </summary>
        /// <param name="depth">Количество отступов</param>
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " -> Цена: " + DisplayCost());
        }
    }
}
