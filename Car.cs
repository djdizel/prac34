using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    public class Car : Venicle
    {
        public int Power { get; set; }

        public Car(double price, int maxSpeed, int year, bool nonBelowZero, bool outOfMaxBorder, int power)
            : base(price, maxSpeed, year, nonBelowZero, outOfMaxBorder)
        {
            Power = power;
        }

        public override string GetType() => "Car";

        public override void Display()
        {
            Console.WriteLine("Тип: Машина");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Максимальная скорость: {MaxSpeed}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Движение при t<0: {(NonBelowZero ? "Да" : "Нет")}");
            Console.WriteLine($"Превышение габаритов: {(OutOfMaxBorder ? "Да" : "Нет")}");
            Console.WriteLine($"Мощность: {Power}");
        }
    }
}
