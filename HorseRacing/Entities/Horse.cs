using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class Horse : BaseEntity
    {
      
        public int Age { get; set; }
        public string Region { get; set; }
        public Jockey Jockey { get; set; } // atın üzerinde ki jokeyi direkt jokey class'ından alıyorz

    }
}
