using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Mod04.DZ;


namespace CarConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            cars[0] = new Car("Toyota", "Camry", 2020, 25000, true);
            cars[1] = new Car("Honda", "Civic", 2019, 23000, true);
            cars[2] = new Car("Ford", "Focus", 2021, 22000, false);
            cars[3] = new Car("Chevrolet", "Malibu", 2018, 24000, true);
            cars[4] = new Car("Nissan", "Altima", 2017, 20000, false);

            // Отобразить количество и сумму цены автомобилей
            Car.DisplayTotalCarsAndPrice();

            // Изменение информаций о машине
            cars[0].DisplayCarDetails();
            cars[0].SetPrice(26000);
            cars[0].SetAvailability(false);
            cars[0].DisplayCarDetails();

            // Измените информаций о машине, используя ссылку
            string newMake = "Toyota";
            string newModel = "RAV4";
            int newYear = 2022;
            cars[0].ModifyCarDetails(ref newMake, ref newModel, ref newYear);
            cars[0].DisplayCarDetails();
        }
    }
}
