using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp.Vehicles
{
    class Car : Vehicle
    {
        private readonly int _maxSpeed;
        private  int _currentSpeed;

        public Car(int xCoord, int yCoord, int zCoord, int price, int speed, DateTime year, int maxSpeed, int currentSpeed)
                    :base(xCoord,yCoord,zCoord,price,speed,year)
        {

            Speed = currentSpeed;
            _maxSpeed = maxSpeed;
        
        }

        public override int Speed
        {
            get => _currentSpeed;
            set
            {
                if (value > _maxSpeed)
                {
                    Console.WriteLine($"{this.GetType()} Maximum speed exceeded  (Override Speed Property)\n  ");
                }
              
                else
                    _currentSpeed = value;
            }
        }

        public override string ToString()
        {
            return $"XCoord:{XCoord},YCoord:{YCoord},ZCoord:{ZCoord},TravelPrice:{Price},\nSpeed:{Speed}," +
                $"Year {YearOfIssue}, CurrentSpeed {_currentSpeed}\n";
        }
    }
}
