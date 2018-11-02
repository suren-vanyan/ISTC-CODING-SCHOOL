using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisChampionship
{
    class Courts
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Capacity { get; set; }
        public string Surface { get; set; }

        public Courts(string name,string city,int capacity,string surface)
        {
            Name = name;
            City = city;
            Capacity = capacity;
            Surface = surface;
           
        }
        public Courts()
        {

        }
    }
}
