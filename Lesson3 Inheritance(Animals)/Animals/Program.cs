using System;
using Animals.Animals;
using Animals.Carnivore;
using Animals.Herbivore;
using Animals.Omnivore;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Animal", 0);

            Beaver beaver = new Beaver(true, 4, "Cheap", "Beaver1", 10);
            Console.WriteLine($"{beaver.Name}\nCan walks? {beaver.CanWalk} \nHas a {beaver.Fur} Fur" +
                $"\n{beaver.Legs} Legs,\nSpeed is {beaver.Speed} " );
            Console.WriteLine($"{beaver.Name} eats {beaver.Eat()}");
            Console.WriteLine(beaver.Sleep(true));
            Console.WriteLine(new string('*',50));

            Rabbit rabbit = new Rabbit(true, 4, "Expencive", "Rabbit1", 30);
            Console.WriteLine($"{rabbit.Name}\nCan walks? {rabbit.CanWalk} \nHas a {rabbit.Fur} Fur" +
                $"\n{rabbit.Legs} Legs,\nSpeed is {rabbit.Speed} ");
            Console.WriteLine($"{rabbit.Name} eats {rabbit.Eat()}");
            Console.WriteLine(rabbit.Sleep(false));
            Console.WriteLine(new string('*', 50));


            Tiger tiger = new Tiger(true, 4, "Very Expencive", "Tiger1", 50);
            Console.WriteLine($"{tiger.Name}\nCan walks? {tiger.CanWalk} \nHas a {tiger.Fur} Fur" +
                $"\n{tiger.Legs} Legs,\nSpeed is {tiger.Speed} ");
            Console.WriteLine($"{tiger.Name} eats {tiger.Eat()}");
            Console.WriteLine(rabbit.Sleep(true));
            Console.WriteLine(new string('*', 50));


        }
    }
}
