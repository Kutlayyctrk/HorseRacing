using HorseRacing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class RaceDay : IBaseEntites
    {
        public override string ToString()
        {
            return Name;
        }
        public RaceDay(string name, DateTime date)
        {
            Id = ++counter;
            Name = name;
            Date = date;
            

        }

       public RaceDay() { }

        public static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; } //tarih
        public List<RaceCard> RaceCards { get; set; } //o güne ait bültenler. 1 günde birden fazla bülten olabilir.
    }
}
