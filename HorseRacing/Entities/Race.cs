using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class Race :BaseEntity
    {
       
        public List<Horse> Horses { get; set; } //yarış içindeki atlar. 1 yarışta birden fazla at olabilir.

        public RaceCard RaceCard { get; set; } //



    }
}
