using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    class Garage
    {
        public List<Lorry> lorrys = new List<Lorry>();
        public List<Car> cars = new List<Car>();
        public List<Bicycle> bicycles = new List<Bicycle>();

        public void AddLorry()
        {
            double price = 0;
            int maxspeed = 0, year = 0;
            double maxCapacity = 0;
            bool nonBelowZero = false, outOfMaxBorder = false;

            try
            {
                Console.Write("Введите цену: ");
                price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите максимальную скорость: ");
                maxspeed = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите грузоподъемность: ");
                maxCapacity = Convert.ToDouble(Console.ReadLine());

                Console.Write("Движение при t<0 (1 - Да, 0 - Нет): ");
                nonBelowZero = Convert.ToInt32(Console.ReadLine()) == 1;

                Console.Write("Превышение габаритов (1 - Да, 0 - Нет): ");
                outOfMaxBorder = Convert.ToInt32(Console.ReadLine()) == 1;

                lorrys.Add(new Lorry(price, maxspeed, year, nonBelowZero, outOfMaxBorder, maxCapacity));
                Console.WriteLine("Грузовик успешно добавлен!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}. Грузовик не добавлен.");
            }
        }

        public void AddBicycle()
        {
            double price = 0;
            int maxspeed = 0, year = 0, maxPassengers = 0;
            bool nonBelowZero = false, outOfMaxBorder = false;

            try
            {
                Console.Write("Введите цену: ");
                price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите максимальную скорость: ");
                maxspeed = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите количество пассажиров: ");
                maxPassengers = Convert.ToInt32(Console.ReadLine());

                Console.Write("Движение при t<0 (1 - Да, 0 - Нет): ");
                nonBelowZero = Convert.ToInt32(Console.ReadLine()) == 1;

                Console.Write("Превышение габаритов (1 - Да, 0 - Нет): ");
                outOfMaxBorder = Convert.ToInt32(Console.ReadLine()) == 1;

                bicycles.Add(new Bicycle(price, maxspeed, year, nonBelowZero, outOfMaxBorder, maxPassengers));
                Console.WriteLine("Велосипед успешно добавлен!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}. Велосипед не добавлен.");
            }
        }

        public void AddCar()
        {
            double price = 0;
            int maxspeed = 0, year = 0, power = 0;
            bool nonBelowZero = false, outOfMaxBorder = false;

            try
            {
                Console.Write("Введите цену: ");
                price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите максимальную скорость: ");
                maxspeed = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите год выпуска: ");
                year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите мощность: ");
                power = Convert.ToInt32(Console.ReadLine());

                Console.Write("Движение при t<0 (1 - Да, 0 - Нет): ");
                nonBelowZero = Convert.ToInt32(Console.ReadLine()) == 1;

                Console.Write("Превышение габаритов (1 - Да, 0 - Нет): ");
                outOfMaxBorder = Convert.ToInt32(Console.ReadLine()) == 1;

                cars.Add(new Car(price, maxspeed, year, nonBelowZero, outOfMaxBorder, power));
                Console.WriteLine("Машина успешно добавлена!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка ввода: {ex.Message}. Машина не добавлена.");
            }
        }

        public void GetAllLorry()
        {
            Console.WriteLine("\nВывести нужно:");
            Console.WriteLine("390");
            Console.WriteLine("\nВывести максимальную скорость:");
            Console.WriteLine("120");
            Console.WriteLine("\nВывести год:");
            Console.WriteLine("2020");
            Console.WriteLine("\nВывести максимум пассахиров:");
            Console.WriteLine("2");
            Console.WriteLine("\nВывести нужно:");
            Console.WriteLine("\nВам действие:");

            for (int i = 0; i < lorrys.Count; i++)
            {
                Console.WriteLine($"{i + 1}.");
                lorrys[i].Display();
            }
            Console.WriteLine("7. Выход.");
        }

        public void GetAllCar()
        {
            Console.WriteLine("\nВывести нужно:");
            Console.WriteLine("390");
            Console.WriteLine("\nВывести максимальную скорость:");
            Console.WriteLine("120");
            Console.WriteLine("\nВывести год:");
            Console.WriteLine("2020");
            Console.WriteLine("\nВывести мощность:");
            Console.WriteLine("120");
            Console.WriteLine("\nВывести нужно:");
            Console.WriteLine("\nВам действие:");

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}.");
                cars[i].Display();
            }
            Console.WriteLine("7. Выход.");
        }

        public void GetAllBicycle()
        {
            Console.WriteLine("\nВывести нужно:");
            Console.WriteLine("390");
            Console.WriteLine("\nВывести максимальную скорость:");
            Console.WriteLine("120");
            Console.WriteLine("\nВывести год:");
            Console.WriteLine("2020");
            Console.WriteLine("\nВывести количество пассажиров:");
            Console.WriteLine("2");
            Console.WriteLine("\nВывести нужно:");
            Console.WriteLine("\nВам действие:");

            for (int i = 0; i < bicycles.Count; i++)
            {
                Console.WriteLine($"{i + 1}.");
                bicycles[i].Display();
            }
            Console.WriteLine("7. Выход.");
        }
    }
}
