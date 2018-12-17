using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrainStation
{
    struct Train:IComparable<Train>
    {
        private string _destination;
        private int _trainNumber;
        private DateTime _departureTime;
     
        public Train(string destination,int trainNumber,DateTime departureTime)
        {
            _destination = destination;
            _departureTime = departureTime;
            _trainNumber = trainNumber;     
           
        }

        public int TrainNumber { get => _trainNumber;  }

        public int CompareTo(Train other)
        {
            return this.TrainNumber.CompareTo(other.TrainNumber);
        }
        public override string ToString()
        {
            return $"TrainNumber{_trainNumber} destination{_destination} DepartureTime{_departureTime}";
        }

    }
}
