using System;
using System.Collections.Generic;
using System.Text;

namespace WorldՕfAnimals.Zoo.AirAnimals
{
    class Falcon : AirAnimals
    {

        public override string Eat()
        {
            return string.Format($"{Name} eats {Food}");
        }

        public override int BodyTemperature { get => base.BodyTemperature; set => base.BodyTemperature = value; }

       

        public override string LivingPlace()
        {
            return $"{Name}  are widely distributed on all continents of the world except Antarctica," +
                $" though closely related raptors did occur there in the Eocene";

        }

        public override string Move()
        {
            if (Energy > 5)
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
            return this;
        }

        public override string ToString()
        {
            return string.Format($"His name is {Name}․He is {Age} Years Old \nEnergy:{Move()} \n:{Eat()} \n:{LivingPlace()} ");
        }
    }
}

