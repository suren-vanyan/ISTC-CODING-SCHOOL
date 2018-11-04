using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals
{
    class Animal
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Animal(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public string Sleep(bool sleep)
        {
            string temp = sleep ? "slepping" : "Not Sleeping";
            return string.Format($"This animal is {temp} ");
        }

        
    }
}
