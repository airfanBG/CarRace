using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    public class CasualRace : Race
    {
        public CasualRace(int length, string route, int prizepool) : base(length, route, prizepool)
        {
        }

        public override int GetPerformance(int id)
        {
            var res = this.Participants[id];

            return (res.HorsePower / res.Acceleration) + (res.Suspension + res.Durability);
        }
    }
}
