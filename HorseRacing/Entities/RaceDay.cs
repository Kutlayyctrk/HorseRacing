using HorseRacing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class RaceDay :IBaseEntites
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; } //tarih
        public List<RaceCard> RaceCards { get; set; } //o güne ait bültenler. 1 günde birden fazla bülten olabilir.
    }
}
