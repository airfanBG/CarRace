using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public int HorsePower { get; set; }
        public int Acceleration { get; set; }
        public int Suspension { get; set; }
        public int Durability { get; set; }

        public Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
        {
            this.Brand = brand;
            this.Model = model;
            this.YearOfProduction = yearOfProduction;
            this.HorsePower = horsePower;
            this.Acceleration = acceleration;
            this.Suspension = suspension;
            this.Durability = durability;
        }
        public virtual void Tune(int tuneIndex,string addon )
        {
            this.HorsePower += tuneIndex;
            this.Suspension += tuneIndex / 2;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Brand} {this.Model} { this.YearOfProduction}");
            sb.AppendLine($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s");
            sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability}");
            sb.AppendLine("Durability");
            return sb.ToString();
        }
    }
}
