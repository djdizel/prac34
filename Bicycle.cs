using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    class Bicycle : Venicle
    {
        int maxPassengers;

        public int MaxPassengers { get; set; }

        public Bicycle(int maxspeed, int price, int year, int maxPassengers) : base(maxspeed, price, year)
        {
            MaxPassengers = maxPassengers;
        }

        public static Bicycle Enter()
        {
            Console.Clear();
            Console.WriteLine($"Тип:Велосипед");
            Console.Write($"Максимальная скорость:");
            int maxspeed = int.Parse(Console.ReadLine());
            Console.WriteLine($"Цена:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine($"Год выпуска:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Максимум пассажиров:");
            int maxPassengers = int.Parse(Console.ReadLine());
            Console.WriteLine($"Мощность в пределах нормы:");
            bool OutOfMaxBorder = bool.Parse(Console.ReadLine());
            Console.WriteLine($"Значения не отрицательные:");
            bool NonBellowZero = bool.Parse(Console.ReadLine());
            return new Bicycle(maxspeed,price,year,maxPassengers);
        }

    }
}
