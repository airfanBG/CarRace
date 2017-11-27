using Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    public abstract class Race
    {
        public int Length { get; set; }
        public string Route { get; set; }
        public int PrizePool { get; set; }
        public Dictionary<int, Car> Participants { get; set; }
        public List<Car> Winner { get; set; }

        public Race(int length, string route, int prizepool)
        {
            this.Length = length;
            this.Route = route;
            this.PrizePool = prizepool;
            this.Participants = new Dictionary<int, Car>();
            this.Winner = new List<Car>();
        }
        public abstract int GetPerformance(int id);

        public Dictionary<int, Car> GetWinners()
        {
            var res = this.Participants.OrderByDescending(x => this.GetPerformance(x.Key)).Take(3).ToDictionary(x => x.Key, m => m.Value);
            return res;
        }
        public List<int> GetPrizes()
        {
            var res = new List<int>();
            res.Add(this.PrizePool * 50 / 100);
            res.Add(this.PrizePool * 30 / 100);
            res.Add(this.PrizePool * 20 / 100);
            return res;
        }
        public string StartRace()
        {
            var winners = GetWinners();
            var prizes = GetPrizes();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Length}");

            for (int i = 0; i < winners.Count; i++)
            {
                var car = winners.ElementAt(i);
                var res= sb.AppendLine($"{i + 1}. {car.Value.Brand} {car.Value.Model} {this.GetPerformance(car.Key)}PP - ${prizes[i]}").ToString().Trim();
                return res;
            }
            return sb.ToString();
        }
    }
}
