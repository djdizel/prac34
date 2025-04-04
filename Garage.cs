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
            int prise = 0, maxspeed = 0, year = 0, MaxCapacity = 0;
            Console.Write("Введите максимальную скорость: ");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Write("Введите грузоподъемность: ");
                try
                {
                    MaxCapacity = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    lorrys.Add(new Lorry(prise, maxspeed, year, MaxCapacity));
                }
            }
        }

        public void AddBicycle()
        {
            int prise = 0, maxspeed = 0, year = 0, MaxPassengers = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите максимальную скорость");
                try
                {
                    maxspeed = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите год:");
                    try
                    {
                        year = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите количество пассажиров:");
                        try
                        {
                            MaxPassengers = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            bicycles.Add(new Bicycle(prise, maxspeed, year, MaxPassengers));
                        }
                    }
                }
            }
        }

        public void AddCar()
        {
            int prise = 0, maxspeed = 0, year = 0, Power = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введите максимальную скорость");
                try
                {
                    maxspeed = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите год:");
                    try
                    {
                        year = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите мощность:");
                        try
                        {
                            Power = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            cars.Add(new Car(prise, maxspeed, year, Power));
                        }
                    }
                }
            }
        }

        public void GetAllLorry()
        {
            foreach (Lorry lorry in lorrys)
            {
                Console.WriteLine($"Год: {lorry.Year}\tМаксимальная скорость: {lorry.Maxspeed}\tГрузоподъемность: {lorry.MaxCapacity}");
            }
        }

        public void GetAllCar()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"Год: {car.Year}\tМаксимальная скорость: {car.Maxspeed}\tМощность: {car.Power}");
            }
        }

        public void GetAllBicycle()
        {
            foreach (Bicycle bicycle in bicycles)
            {
                Console.WriteLine($"Год: {bicycle.Year}\tМаксимальная скорость: {bicycle.Maxspeed}\tКоличество пассажиров: {bicycle.MaxPassengers}");
            }
        }
    }
}
