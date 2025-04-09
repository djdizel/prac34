using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac34
{
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

                Garage garage = new Garage();
                bool running = true;

                while (running)
                {
                    Console.WriteLine("\nВыберите действие:");
                    Console.WriteLine("1. Добавить в список велосипед;");
                    Console.WriteLine("2. Добавить в список машину;");
                    Console.WriteLine("3. Добавить в список грузовик;");
                    Console.WriteLine("4. Вывести все велосипеды из списка;");
                    Console.WriteLine("5. Вывести все машины из списка;");
                    Console.WriteLine("6. Вывести все грузовики из списка;");
                    Console.WriteLine("7. Выход.");

                    Console.Write("Введите номер: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            garage.AddBicycle();
                            break;
                        case "2":
                            garage.AddCar();
                            break;
                        case "3":
                            garage.AddLorry();
                            break;
                        case "4":
                            garage.GetAllBicycle();
                            break;
                        case "5":
                            garage.GetAllCar();
                            break;
                        case "6":
                            garage.GetAllLorry();
                            break;
                        case "7":
                            running = false;
                            Console.WriteLine("Завершение.");
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Попробуйте снова.");
                            break;
                    }
                }
            }
        }
    }
}
