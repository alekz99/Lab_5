using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    /// <summary>
    /// Класс, реализующий составной объект
    /// Определяет поведение компонентов, у которых есть потомки
    /// </summary>
    class Composite : Equipment
    {
        private List<Equipment> equipments = new List<Equipment>();
        public Composite(string name) : base(name) { }

        /// <summary>
        /// Добавление нового объекта
        /// </summary>
        /// <param name="equips">Добавляемый объект</param>
        public void Add(Equipment equips)
        {
            equipments.Add(equips);
        }

        /// <summary>
        /// Удаление объекта
        /// </summary>
        /// <param name="equips">Удаляемый объект</param>
        public void Remove(Equipment equips)
        {
            equipments.Remove(equips);
        }

        /// <summary>
        /// Переопределнный метод для вывода стоимости составного объекта
        /// </summary>
        /// <returns></returns>
        public override int DisplayCost()
        {
            int all_cost = 0;
            foreach (Equipment equip in equipments)
            {
                all_cost += equip.DisplayCost();
            }
            return all_cost;
        }

        /// <summary>
        /// Переопределенный метод для вывода структуры составного объекта
        /// </summary>
        /// <param name="depth"></param>
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " -> Цена: " + DisplayCost());
            foreach (Equipment eq in equipments)
            {
                eq.Display(depth + 2);
            }
        }
    }
}
