using System;

namespace lab_5
{
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список аргументов командной строки</param>
        static void Main(string[] args)
        {
            string nameObject;
            int cost = 0;

            Console.WriteLine("Введите имя автомобиля: ");
            nameObject = Console.ReadLine();
            Car myCar = new Car(nameObject);

            Console.WriteLine("Введите имя корпуса: ");
            nameObject = Console.ReadLine();
            Body myBody = new Body(nameObject);
            Console.WriteLine("Введите название деталей для корпуса: ");
            nameObject = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Введите цену " + nameObject + ": ");
                try
                {
                    cost = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверная стоимость!");
                }
            }
            myBody.Add(new Tools(nameObject, cost));
            Console.WriteLine("Введите название фар для корпуса: ");
            nameObject = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Введите цену " + nameObject + ": ");
                try
                {
                    cost = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверная стоимость!");
                }
            }
            myBody.Add(new Headlights(nameObject, cost));
            myCar.Add(myBody);

            Console.WriteLine("Введите имя двигателя: ");
            nameObject = Console.ReadLine();
            Engine myEngine = new Engine(nameObject);

            Console.WriteLine("Введите название деталей для двигателя: ");
            nameObject = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Введите цену " + nameObject + ": ");
                try
                {
                    cost = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверная стоимость!");
                }
            }
            myEngine.Add(new Tools(nameObject, cost));
            myCar.Add(myEngine);

            Console.WriteLine("Введите название трансмиссии: ");
            nameObject = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Введите цену " + nameObject + ": ");
                try
                {
                    cost = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверная стоимость!");
                }
            }
            myCar.Add(new Transmission(nameObject, cost));

            Console.WriteLine("Введите название инструментов: ");
            nameObject = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Введите цену " + nameObject + ": ");
                try
                {
                    cost = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Неверная стоимость!");
                }
            }
            myCar.Add(new Tools(nameObject, cost));

            Console.WriteLine("Структура автомобиля:");
            myCar.Display(2);
            Console.WriteLine("Стоимость всего автомобиля: " + myCar.DisplayCost());

        }
    }
}
