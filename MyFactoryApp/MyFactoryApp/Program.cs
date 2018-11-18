using System;

namespace MyFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {         
            PizzaStore gumriStore = new GumriPizzaStore();
            gumriStore.OrderPizza("hawaii");
            Console.WriteLine("\n");

            PizzaStore erevanStore = new ErevanPizzaStore();
            erevanStore.OrderPizza("Diabola");
            Console.WriteLine("\n");

            PizzaStore vanadzorStore = new VanadzorPizzaStore();
            vanadzorStore.OrderPizza("Margherita");
        }
    }
}
