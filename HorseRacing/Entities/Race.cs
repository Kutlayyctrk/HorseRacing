using HorseRacing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class Race : IBaseEntites
    {
        public Race(string name, List<Horse> horse)
        {
            Id = ++counter;

        }
        public Race()
        {

        }
        

        public static int counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Horse> Horses { get; set; } //yarış içindeki atlar. 1 yarışta birden fazla at olabilir.

        public RaceCard RaceCard { get; set; } //



    }
}
