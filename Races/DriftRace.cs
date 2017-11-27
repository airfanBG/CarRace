using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    public class DriftRace : Race
    {
        public DriftRace(int length, string route, int prizepool) : base(length, route, prizepool)
        {
        }

        public override int GetPerformance(int id)
        {
            var res = this.Participants[id];

            return (res.Suspension+res.Durability);
        }
    }
}
