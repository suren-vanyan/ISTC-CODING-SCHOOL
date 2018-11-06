using System;
using System.Collections.Generic;
using System.Text;

namespace WorldՕfAnimals.Zoo.AirAnimals
{
    class Pigeon:AirAnimals
    {
        public override string Eat()
        {
            return string.Format($"{Name} eats {Food}");
        }

        public override string LivingPlace()
        {
          return  $"To know where he lives {Name} go to https://en.wikipedia.org/wiki/Columba_(genus";
        }

        public override string Move()
        {
            if (Energy > 4)
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
