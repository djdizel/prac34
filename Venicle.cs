using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    abstract class Venicle
    {
        int maxspeed;
        protected bool NonBellowZero;
        protected bool OutOfMaxBorder;
        double price;
        int year;

        public int Maxspeed { get => maxspeed; set => maxspeed = value; }
        public double Price { get => price; set => price = value; }
        public int Year { get => year; set => year = value; }
        

        public Venicle(int maxspeed,int price, int year)
        {
            Maxspeed = maxspeed;
            Price = price;
            Year = year;
        }

    }
}
