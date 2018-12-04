using System;
using WorldՕfAnimals.Zoo.AirAnimals;
using WorldՕfAnimals.Zoo.LandAnimals;
using WorldՕfAnimals.Zoo.WaterAnimals;
using WorldՕfAnimals.Zoo;

namespace World_of_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            AirAnimals[] airAnimals = new AirAnimals[]
            {
                new Crane
                {
                    Name="Crane1",
                    Age=3,
                    Energy=8,
                    Food="Fish",
                    Gender=Gender.Male,
                    Color="Blue",
                    BodyTemperature=50,
                    Wings=true,
                    Feathers=true,
                    CanFly=true,
                },

                new Crow
                {
                    Name="Crow1",
                    Age=1,
                    Energy=10,
                    Food="Worm",
                    Gender=Gender.Female,
                    Color="Black",
                    BodyTemperature=50,
                     Wings=true,
                    Feathers=true,
                    CanFly=true,

                },

                 new Eagle
                {
                    Name="Eagle",
                    Age=2,
                    Energy=6,
                    Food="Frog",
                    Gender=Gender.Male,
                    Color="Black",
                    BodyTemperature=45,
                     Wings=true,
                    Feathers=true,
                    CanFly=true,

                },

                 new Falcon
                 {
                     Name="Falcon",
                    Age=5,
                    Energy=8,
                    Food="Bird",
                    Gender=Gender.Male,
                    Color="White",
                    BodyTemperature=45,
                     Wings=true,
                    Feathers=true,
                    CanFly=true,
                 }
            };


            LandAnimals[] landAnimals = new LandAnimals[]
            {
                new Muridae
                {
                    Name="Muradie1",
                    Age=2,
                    Energy=4,
                    Food="Cheese",
                    Gender=Gender.Male,
                    Color="Grow",
                    BodyTemperature=50,
                    Fur=true,
                    CanWalk=true,
                },

                new Rabbit
                {
                     Name="Rabbit1",
                    Age=4,
                    Energy=6,
                    Food="Carrot",
                    Gender=Gender.Female,
                    Color="Black",
                    BodyTemperature=47,
                    Fur=true,
                    CanWalk=true,
                },

            };

          
            MyZoo myZoo = new MyZoo(airAnimals,landAnimals);    
            Console.WriteLine($"There are {landAnimals.Length + airAnimals.Length} animals in the zoo");
            Console.WriteLine(new string('*', 50));


            foreach (var item in landAnimals)
            {
              
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(item);
                Console.WriteLine("Type FullName:" + item.GetTypes());
                Console.WriteLine(new string('*', 50));
                Console.ResetColor();
            }
            foreach (var item in airAnimals)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(item);
                Console.WriteLine("Type FullName:"+ item.GetTypes());
                Console.WriteLine(new string('*',50));
                Console.ResetColor();
            }

            
        }
    }
}
