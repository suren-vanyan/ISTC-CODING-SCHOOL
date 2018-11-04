using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Omnivore
{
    class Man:Omnivore
    {
        public int Age { get; set; }

        public Man(int age,string name, int speed):base(name,speed)
        {
            Age = age;
        }


    }
}
