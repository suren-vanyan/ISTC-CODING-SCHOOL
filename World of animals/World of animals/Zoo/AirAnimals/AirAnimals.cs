using System;
using System.Collections.Generic;
using System.Text;

namespace WorldՕfAnimals.Zoo.AirAnimals
{
    class AirAnimals:Animals
    {
        //https://hy.wikipedia.org/wiki/%D4%B9%D5%BC%D5%B9%D5%B8%D6%82%D5%B6%D5%B6%D5%A5%D6%80

        public bool Wings { get; set; }
        public bool Feathers { get; set; }
        public bool CanFly { get; set; }

        public override int BodyTemperature
        {
            get => _bodyTemperature;
            set
            {
                if(value>=40 && value <= 70)
                {
                    _bodyTemperature = value;
                }
            }

        }
    }
}
