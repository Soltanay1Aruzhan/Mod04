using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Animal : IComparable<Animal>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public abstract void CalculateFood();

        public int CompareTo(Animal other)
        {
            
            int FoodComparison = other.FoodAmount.CompareTo(this.FoodAmount);
            if (FoodComparison != 0)
                return FoodComparison;

            
            return this.Name.CompareTo(other.Name);
        }

        
        public abstract double FoodAmount { get; set; }
        public abstract string FoodType { get; set; }
    }

    
    public class Carnivore : Animal
    {
        public override double FoodAmount { get; set; }
        public override string FoodType { get; set; }

        public override void CalculateFood()
        {
            
            FoodAmount = 10.0;
            FoodType = "Мясо";
        }
    }

    
    public class Omnivore : Animal
    {
        public override double FoodAmount { get; set; }
        public override string FoodType { get; set; }

        public override void CalculateFood()
        {
            
            FoodAmount = 8.0;
            FoodType = "Трава и мясо";
        }
    }

    
    public class Herbivore : Animal
    {
        public override double FoodAmount { get; set; }
        public override string FoodType { get; set; }

        public override void CalculateFood()
        {
            
            FoodAmount = 5.0;
            FoodType = "Трава";
        }
    }
}
