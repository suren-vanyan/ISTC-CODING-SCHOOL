using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisChampionship
{
    class Matches
    {
        public DateTime Date { get; set; }
        public Rounds Round { get; set; }
        public string Time { get; set; }
        public Courts Courts { get; set; } = new Courts();
        public Tournaments tournament { get; set; }

        public Matches(Courts courts)
        {
            Courts = courts;
           
        }
    }
}
