using System;
using System.Collections.Generic;
using System.Text;

namespace WorldՕfAnimals.Zoo
{
    class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Energy { get; set; }
        public string Food { get; set; }
        public Gender Gender { get; set; }
        public string Color { get; set; }
        

        protected int _bodyTemperature;
        public virtual int BodyTemperature { get => _bodyTemperature; set => _bodyTemperature = value; }

        public virtual string LivingPlace { get; set; }
        public virtual void Move() { }   
        public virtual string Eat() { return string.Empty; }
        public virtual object GetTypes()
        {
            return this;
        }
    }
}
