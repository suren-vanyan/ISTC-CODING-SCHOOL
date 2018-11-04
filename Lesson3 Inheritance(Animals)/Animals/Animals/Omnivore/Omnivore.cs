using System;
using System.Collections.Generic;
using System.Text;
using Animals.Animals;

namespace Animals.Omnivore
{
    class Omnivore : Animal
    {
        public Omnivore(string name, int speed):base(name,speed)
        {

        }

        public string Eat()
        {
            return "Can eat everything";
        }
    }
}
