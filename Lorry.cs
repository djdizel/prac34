using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    public class Lorry : Venicle
    {
        public double MaxCapacity { get; set; }

        public Lorry(double price, int maxSpeed, int year, bool nonBelowZero, bool outOfMaxBorder, double maxCapacity)
            : base(price, maxSpeed, year, nonBelowZero, outOfMaxBorder)
        {
            MaxCapacity = maxCapacity;
        }

        public override string GetType() => "Lorry";

        public override void Display()
        {
            Console.WriteLine("Тип: Грузовик");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Максимальная скорость: {MaxSpeed}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Движение при t<0: {(NonBelowZero ? "Да" : "Нет")}");
            Console.WriteLine($"Превышение габаритов: {(OutOfMaxBorder ? "Да" : "Нет")}");
            Console.WriteLine($"Максимальная грузоподъёмность: {MaxCapacity}");
        }
    }
}
