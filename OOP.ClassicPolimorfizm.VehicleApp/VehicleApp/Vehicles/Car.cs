using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp.Vehicles
{
    class Car : Vehicle
    {
        private readonly int _maxSpeed;
        private int _currentSpeed;

        public Car(int xCoord, int yCoord, int zCoord, int price,  DateTime year, int maxSpeed, int currentSpeed)
                    : base(xCoord, yCoord,default(int), zCoord, price,  year)
        {
            _maxSpeed = maxSpeed;
            CurrentSpeed = currentSpeed;
            

        }

        public  int CurrentSpeed
        {
            get => _currentSpeed;
            set
            {
                if (value <= _maxSpeed)
                    _currentSpeed = value;

                else
                    throw new ArgumentException($"{this.GetType()} Maximum speed exceeded  (Override Speed Property)\n ");
            }
        }

        public override string ToString()
        {
            return $"XCoord:{XCoord},YCoord:{YCoord},ZCoord:{ZCoord},TravelPrice:{Price},\nSpeed:{CurrentSpeed}," +
                $"Year {YearOfIssue}, CurrentSpeed {_currentSpeed}\n";
        }
    }
}
