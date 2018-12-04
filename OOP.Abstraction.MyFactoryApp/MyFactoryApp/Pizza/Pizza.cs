using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryApp
{
  public abstract  class  Pizza
    {
        public abstract void Prepare();
        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
        public string Name { get; set; }
        public string PizzaKit { get; set; }
        public Pizza(string name, string pizzaKit)
        {
            Name = name;
            PizzaKit = pizzaKit;
        }
    }
}
