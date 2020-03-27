using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    /// <summary>
    /// Класс, объявляет интерфейс для компонуемых объектов
    /// Объявляет интерфейс для доступа к потомкам и управлению ими
    /// </summary>
    abstract class Equipment
    {
        protected string name;
        protected int cost;
        /// <summary>
        /// Конструктор класс
        /// </summary>
        /// <param name="name"></param>
        public Equipment(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Конструктор клааса для конечных деталаей
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cost"></param>
        public Equipment(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }
        /// <summary>
        /// Метод для возврата имени детали
        /// </summary>
        /// <returns>Возвращает строку имени</returns>
        public string Name() { return name; }
        /// <summary>
        /// Абстрактный метод для возврата стоимости детали
        /// </summary>
        /// <returns></returns>
        public abstract int DisplayCost();

        /// <summary>
        /// Абстрактный метод для отображения объета
        /// </summary>
        /// <param name="depth">Количество отступов для начального объекта</param>
        public abstract void Display(int depth);
    }
}
