using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04.DZ
{
    public partial class Car
    {
        //Отображение информации о машине
        public void DisplayCarDetails()
        {
            Console.WriteLine("Make: " + this.Make);
            Console.WriteLine("Model: " + this.Model);
            Console.WriteLine("Year: " + this.Year);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Available: " + this.IsAvailable);
        }

        public void SetPrice(double newPrice)
        {
            this.Price = newPrice;
            TotalPrice += (newPrice - this.Price);
        }

        public void SetAvailability(bool availability)
        {
            this.IsAvailable = availability;
        }
        public bool GetAvailability()
        {
            return IsAvailable;
        }

        public static void DisplayTotalCarsAndPrice()
        {
            Console.WriteLine("Total cars: " + TotalCars);
            Console.WriteLine("Total price: " + TotalPrice);
        }
        public void ModifyCarDetails(ref string newMake, ref string newModel, ref int newYear)
        {
            this.Make = newMake;
            this.Model = newModel;
            this.Year = newYear;
        }
    }
}
