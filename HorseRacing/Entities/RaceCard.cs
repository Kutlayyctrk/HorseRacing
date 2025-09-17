using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class RaceCard : BaseEntity
    {
      
        public string Place { get; set; }
        public List<Race> Races { get; set; } //bülten içindeki yarışlar. 1 bültende birden fazla yarış olabilir.
        


    }
}
