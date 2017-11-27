using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class ShowCar : Car
    {
        public int Stars { get; set; }
        public ShowCar(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability, int stars=0) : base(brand, model, yearOfProduction, horsePower, acceleration, suspension, durability)
        {
            this.Stars = stars;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine($"{this.Stars} *");
            return sb.ToString();
        }
        public override void Tune(int tuneIndex, string addon)
        {
            base.Tune(tuneIndex, addon);
            this.Stars += tuneIndex;
        }
    }
}
