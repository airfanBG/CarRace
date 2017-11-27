using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class PerformanceCar : Car
    {
        public List<string> AddOns { get; set; }

        
        public PerformanceCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
        {
            this.HorsePower = (int)(horsePower*3/2);
            this.Suspension = this.Suspension*25/100;
            AddOns = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            if (AddOns.Count > 0)
            {
                sb.Append($"Add-ons: ");
                for (int i = 0; i < AddOns.Count; i++)
                {
                    
                    if (AddOns.Count > 0)
                    {
                        var t = AddOns.Count > 1 ? "," : "";
                        sb.Append($"{this.AddOns[i]}{t}");
                    }
                }
            }
            else
            {
                sb.Append("Add-ons: None");
            
            }
            return sb.ToString();
        }
        public override void Tune(int tuneIndex, string addon)
        {
           // base.Tune(tuneIndex, addon);
            this.AddOns.Add(addon);
        }
    }
}
