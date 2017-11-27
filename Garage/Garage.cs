using Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Garage
    {
        public List<int> ParkedCars { get; set; }

        public Garage()
        {
            ParkedCars = new List<int>();
        }
        public void AddCar(int id)
        {
            this.ParkedCars.Add(id);
        }
        public void RemoveCar(int id)
        {
            this.ParkedCars.Remove(id);
        }
        //public void Tune(int tuneIndex, string addOn)
        //{
        //    this.ParkedCars
        //}
    }
}
