using System;
using System.Collections.Generic;
using System.Text;
using Animals.Animals;

namespace Animals.Carnivore
{
    class Carnivore:Animal
    {
        public bool CanWalk { get; set; }
        public int Legs { get; set; }
        public string Fur { get; set; }
        

        public Carnivore(bool canWalk,int legs,string fur,string name,int speed):base(name,speed)
        {
            CanWalk = canWalk;
            Legs = legs;
            Fur = fur;
        }

      
        
        public  string Eat()
        {
            return "Meat";
        }
    }
}
