using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TrainStation
{
    class TrainStation:IEnumerable
    {
        public static Train[] trains = new Train[3];
        public static int count = -1;
        public void AddTrain(Train train)
        {

            if (count >= trains.Length - 1)
            {
                Console.WriteLine("There is no place in the train station anymore");
                return;
            }

            trains[++count] = train;
           
        }

        
        public IEnumerator GetEnumerator()
        {
            foreach (Train train in trains)
            {
                yield return train;
            }
        }
    }
}
