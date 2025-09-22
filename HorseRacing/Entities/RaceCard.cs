using HorseRacing.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class RaceCard : IBaseEntites
    {
        public RaceCard()
        {
            Id = ++counter;
        }
        public static int counter = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public List<Race> Races { get; set; } //bülten içindeki yarışlar. 1 bültende birden fazla yarış olabilir.



    }
}
