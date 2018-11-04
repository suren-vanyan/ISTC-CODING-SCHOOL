using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Herbivore
{
    class Squirrel:Herbivore
    {
        public Squirrel(bool canWalk, int legs, string fur, string name, int speed)
                         : base(canWalk, legs, fur, name, speed)
        {
            CanWalk = canWalk;
            Legs = legs;
            Fur = fur;
        }
    }
}
