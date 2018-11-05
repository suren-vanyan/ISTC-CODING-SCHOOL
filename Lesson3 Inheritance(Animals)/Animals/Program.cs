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
          
            Beaver beaver = new Beaver(true, 4, "Cheap", "Beaver1", 10,2);
            Console.WriteLine(beaver.Name);
            Console.WriteLine($"The dog is {beaver.Age} years old");
            Console.WriteLine($"Has a {beaver.Fur} Fur");
            Console.WriteLine($"Has a {beaver.Legs} Legs");
            Console.WriteLine($"Speed is {beaver.Speed}");
            Console.WriteLine($"{beaver.Name} eats {beaver.Eat()}");
            Console.WriteLine(beaver.Sleep(true));
            Console.WriteLine(new string('*',50));


            Rabbit rabbit = new Rabbit(true, 4, "Expencive", "Rabbit1", 30,1);
            Console.WriteLine(rabbit.Name);
            Console.WriteLine($"The dog is {rabbit.Age} years old");
            Console.WriteLine($"Has a {rabbit.Fur} Fur");
            Console.WriteLine($"Has a {rabbit.Legs} Legs");
            Console.WriteLine($"Speed is {rabbit.Speed}");
            Console.WriteLine($"{rabbit.Name} eats {rabbit.Eat()}");
            Console.WriteLine(rabbit.Sleep(true));
            Console.WriteLine(new string('*', 50));



            Tiger tiger = new Tiger(true, 4, "Very Expencive", "Tiger1",50,8);    
            Console.WriteLine(tiger.Name);
            Console.WriteLine($"The dog is {tiger.Age} years old");
            Console.WriteLine($"Has a {tiger.Fur} Fur");
            Console.WriteLine($"Has a {tiger.Legs} Legs");
            Console.WriteLine($"Speed is {tiger.Speed}");
            Console.WriteLine($"{tiger.Name} eats {tiger.Eat()}");
            Console.WriteLine(tiger.Sleep(true));
            Console.WriteLine(new string('*', 50));

        }
    }
}
