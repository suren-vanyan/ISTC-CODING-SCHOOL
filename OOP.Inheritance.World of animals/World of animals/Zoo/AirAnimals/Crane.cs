using System;
using System.Collections.Generic;
using System.Text;

namespace WorldՕfAnimals.Zoo.AirAnimals
{
    class Crane:AirAnimals
    {
       // https://en.wikipedia.org/wiki/Crane_(bird)
        

        public override string Eat()
        {
            return string.Format($"{Name} eats {Food}");
          
        }

     
        public override string LivingPlace()
        {
            return $"{Name} live on all continents except Antarctica and South America.";
          
        }
            

        public override string Move()
        {
            if (Energy > 10)
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
            return string.Format($"His name is {Name}․He is {Age} Years Old․\nColor:{Color} \nEnergy:{Move()}" +
                                $" \n{Eat()} \n{LivingPlace()} \nBodyTemperature:{BodyTemperature}" +
                                $" \nHave a Wings? {Wings} Have a Feathers?{Feathers} CanFly? {CanFly}");
        }
    }
}
