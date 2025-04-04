using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    class Lorry : Venicle
    {
        int maxCapacity;

        public int MaxCapacity { get; set; }

        public Lorry(int maxspeed, int price, int year, int maxCapacity) : base(maxspeed, price, year)
        {
            MaxCapacity = maxCapacity;
        }
        public static Lorry Enter()
        {
            Console.Clear();
            Console.WriteLine($"Тип:Грузовик");
            Console.Write($"Максимальная скорость:");
            int maxspeed = int.Parse(Console.ReadLine());
            Console.WriteLine($"Цена:");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine($"Год выпуска:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"Объем:");
            int maxCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine($"Мощность в пределах нормы:");
            bool OutOfMaxBorder = bool.Parse(Console.ReadLine());
            Console.WriteLine($"Значения не отрицательные:");
            bool NonBellowZero = bool.Parse(Console.ReadLine());
            return new Lorry(maxspeed, price, year, maxCapacity);
        }

    }
}
