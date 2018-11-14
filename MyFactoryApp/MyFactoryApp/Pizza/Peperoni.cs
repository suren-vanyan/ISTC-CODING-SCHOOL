using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryApp
{
    class Peperoni : Pizza
    {
        public Peperoni(string name,string pizzaKit):base(name,pizzaKit)
        {

        }
        public override void Bake()
        {
            Console.WriteLine("Bake for 20 minutes at 200");
        }

        public override void Box()
        {
            Console.WriteLine("Place Pizza in official PizzaStore Box");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the Pizza into square slices");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing Pizza {this.Name} {this.PizzaKit}");
        }
    }
}
