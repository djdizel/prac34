using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    class Car : Venicle
    {
        int power;

        public int Power { get => power; set => power = value; }

        public Car(int maxspeed, int price, int year, int power) : base (maxspeed,price,year)
        {
            Power = power;
        }
        public static Car Enter()
        {
            Console.Clear();
            Console.WriteLine($"Тип:Автомобиль");
            Console.Write($"Максимальная скорость:");
            int maxspeed = int.Parse(Console.ReadLine());
            Console.WriteLine($"Цена:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine($"Год выпуска:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Мощность:");
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine($"Мощность в пределах нормы:");
            bool OutOfMaxBorder = bool.Parse(Console.ReadLine());
            Console.WriteLine($"Значения не отрицательные:");
            bool NonBellowZero = bool.Parse(Console.ReadLine());
            return new Car(maxspeed, price, year, power);
        }
    }
}
