using HorseRacing.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing.Entities
{
    public class Horse : IBaseEntites
    {
        public override string ToString()
        {
            return Name;
        }
        public Horse(string name,int age, string region, Jockey jokey)
        {
            Name = name;
            Age = age;
            Region = region;
            Jockey = jokey;
            Id = ++counter;
        }
        public static int counter = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Region { get; set; }
        public Jockey Jockey { get; set; } // atın üzerinde ki jokeyi direkt jokey class'ından alıyorz

    }
}
