using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    public abstract class Venicle
    {
        public double Price { get; set; }
        public int MaxSpeed { get; set; }
        public int Year { get; set; }
        public bool NonBelowZero { get; set; }
        public bool OutOfMaxBorder { get; set; }

        public Venicle(double price, int maxSpeed, int year, bool nonBelowZero, bool outOfMaxBorder)
        {
            Price = price;
            MaxSpeed = maxSpeed;
            Year = year;
            NonBelowZero = nonBelowZero;
            OutOfMaxBorder = outOfMaxBorder;
        }

        // Абстрактные методы
        public abstract string GetType();
        public abstract void Display();
    }
}
