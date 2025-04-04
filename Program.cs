using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage garrage = new Garage();
            while (true)
            {
                int i = 0;
                Console.WriteLine("ВЫБЕРИТЕ НУЖНОЕ ВАМ ДЕЙСТВИЕ:");
                Console.WriteLine("1. Добавить в список велосипед");
                Console.WriteLine("2. Добавить в список грузовик");
                Console.WriteLine("3. Добавить в список машину");
                Console.WriteLine("4. Вывести все машины из списка:");
                Console.WriteLine("5. Вывести все грузовики из списка:");
                Console.WriteLine("6. Вывести все грузовики из списка:");
                Console.WriteLine("7. Выход");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    switch (i)
                    {
                        case 1: garrage.AddBicycle(); break;
                        case 2: garrage.AddLorry(); break;
                        case 3: garrage.AddCar(); break;
                        case 4: Console.WriteLine("Велосипеды:"); garrage.GetAllBicycle(); break;
                        case 5: Console.WriteLine("Машины:"); garrage.GetAllCar(); break;
                        case 6: Console.WriteLine("Грузовики:"); garrage.GetAllLorry(); break;
                        case 7: return;
                        default: Console.WriteLine(""); break;
                    }
                }
                catch { }
                Console.Read();
            }
        }
    }
}
