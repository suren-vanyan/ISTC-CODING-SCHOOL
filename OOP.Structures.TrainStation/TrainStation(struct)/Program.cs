using System;
using System.Collections;
using System.Collections.Generic;

namespace TrainStation
{
    class Program
    {
        static void Main(string[] args)
        {     
            Console.WriteLine("To add a new train press key 'a'");
            Console.WriteLine("when the station is full, press another character ");
            TrainStation trainStation = new TrainStation();
            while (Console.ReadKey().KeyChar=='a')
            {
                Console.WriteLine("\n");
                Console.Write("Add destination:");
                string destination = Console.ReadLine();          
                destination = string.IsNullOrEmpty(destination) ? "no destination specified" : destination;
               

                Console.Write("Add trainNumber:");
                bool result = int.TryParse(Console.ReadLine(),out int trainNumber);
                trainNumber = result ? trainNumber : 0;

                Console.Write("Add departureTime:");
                bool d = DateTime.TryParse(Console.ReadLine(),out DateTime departureTime);
                departureTime = d ? departureTime : DateTime.Now;

                trainStation.AddTrain(new Train(destination, trainNumber, departureTime));
                Console.WriteLine("To add a new train press key 'a'");
                
            }
            Array.Sort(TrainStation.trains);

            Console.Write("Choose the train in wich you want to go,\nPlease enter train number:");         
            int chooseTrain =int.Parse( Console.ReadLine()+ Environment.NewLine);
            bool findTrain = false;
            foreach (Train item in trainStation)
            {
               if(item.TrainNumber==chooseTrain)
                {
                    Console.WriteLine(item);
                    findTrain = true;
                }

            }
            if (!findTrain)
            {
                Console.WriteLine("This train not found");
            }
        }
    }
}
