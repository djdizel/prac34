using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    public class Bicycle : Venicle
    {
        public int MaxPassengers { get; set; }

        public Bicycle(double price, int maxSpeed, int year, bool nonBelowZero, bool outOfMaxBorder, int maxPassengers)
            : base(price, maxSpeed, year, nonBelowZero, outOfMaxBorder)
        {
            MaxPassengers = maxPassengers;
        }

        public override string GetType() => "Bicycle";

        public override void Display()
        {
            Console.WriteLine("Тип: Велосипед");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Максимальная скорость: {MaxSpeed}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Движение при t<0: {(NonBelowZero ? "Да" : "Нет")}");
            Console.WriteLine($"Превышение габаритов: {(OutOfMaxBorder ? "Да" : "Нет")}");
            Console.WriteLine($"Максимальное число пассажиров: {MaxPassengers}");
        }
    }
}
