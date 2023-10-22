using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Mod04.DZ
{
    public partial class Car
    {
        private static int TotalCars;
        private static double TotalPrice;
        public Car() : this("")
        {
        }
        public Car(string Make) : this(Make, "", 0)
        {
        }
        public Car(string Make, string Model, int Year)
            : this(Make, Model, Year, 0, true)
        {
        }
        public Car(string Make, string Model, int Year, double Price, bool IsAvailable)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.IsAvailable = IsAvailable;

            TotalCars++;
            TotalPrice += Price;
        }
        private string Make { get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private double Price { get; set; }
        private bool IsAvailable { get; set; }


    }
}
