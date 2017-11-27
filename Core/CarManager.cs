using Cars;
using Garage;
using Races;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CarManager
    {
        private Dictionary<int, Car> RaceCars { get; set; }
        private Dictionary<int, Race> Races { get; set; }
        private Garage.Garage Garage { get; set; }

        public CarManager()
        {
            RaceCars = new Dictionary<int, Car>();
            Races = new Dictionary<int, Race>();
            Garage = new Garage.Garage();
        }

        public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        {
            if (type=="Performance")
            {
                var pc = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                this.RaceCars.Add(id, pc);
            }
            else if (type == "Show")
            {
                var sc = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                this.RaceCars.Add(id, sc);
            }
        }
        public string Check(int id)
        {
            return RaceCars[id].ToString();
        }
        public void Open(int id, string type, int length, string route, int prizePool)
        {
            if (type=="Casual")
            {
                Races.Add(id, new CasualRace(length, route, prizePool));
            }
            else if(type=="Drag")
            {
                Races.Add(id, new DragRace(length, route, prizePool));
            }
            else
            {
                Races.Add(id, new DriftRace(length, route, prizePool));
            }
        }
        public void Participate(int carId, int raceId)
        {
            var carRes = RaceCars.FirstOrDefault(x => x.Key == carId);
            var raceRes = Races.FirstOrDefault(x => x.Key == raceId);

            Races[raceId].Participants.Add(carId,RaceCars[carId]);
        }
        public string Start(int id)
        {
            if (Races[id].Participants.Count == 0)
            {
                return "Cannot start the race with zero participants.";
            }
            var res = Races[id].StartRace();

            return res;

        }
        public void Park(int id)
        {
            Garage.ParkedCars.Add(id);
        }
        public void Unpark(int id)
        {
            Garage.ParkedCars.Remove(id);
        }
        public void Tune(int tuneIndex, string addOn)
        {
            foreach (var item in Garage.ParkedCars)
            {
                RaceCars[item].Tune(tuneIndex, addOn);
            }
        }

    }
}
