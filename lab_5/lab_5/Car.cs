using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    /// <summary>
    /// Основной класс, с которго начинатеся сбор автомобиля
    /// </summary>
    class Car : Composite
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Название автомобиля</param>
        public Car(string name) : base(name) { }

    }
}
