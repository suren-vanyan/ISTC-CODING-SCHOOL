using System;
using System.Collections.Generic;
using System.Text;

namespace WorldՕfAnimals.Zoo.AirAnimals
{
    class Eagle:AirAnimals
    {
        public override string Eat()
        {
            return string.Format($"{Name} eats {Food}");
        }

       // public override int BodyTemperature { get => base.BodyTemperature; set => base.BodyTemperature = value; }

      

        public override string LivingPlace()
        {
            return $"{Name} live on all continents except Antarctica and South America.";

        }

        public override string Move()
        {
            if (Energy > 7)
            {
                return string.Format($"{this.Name}  can walks");
            }
            else
            {
                return string.Format($"{this.Name} has no enough Energy");
            }
        }

        public override object GetTypes()
        {
            return this.GetType();
        }

        public override string ToString()
        {
            return string.Format($"His name is {Name}․He is {Age} Years Old․\nColor:{Color} \nEnergy:{Move()} \n{Eat()} \n{LivingPlace()} \nBodyTemperature:{BodyTemperature}");
        }
    }
}
