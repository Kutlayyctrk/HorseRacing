using HorseRacing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class Jockey : IBaseEntites
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

    }
}
