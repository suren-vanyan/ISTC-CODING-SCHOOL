using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Carnivore
{
    class Tiger:Carnivore
    {
        public Tiger(bool canWalk, int legs, string fur, string name, int speed,int age)
                                              :base(canWalk, legs, fur, name, speed,age)
        {

        }

        public new string Eat()
        {
            return "Deer";
        }
    }
}
