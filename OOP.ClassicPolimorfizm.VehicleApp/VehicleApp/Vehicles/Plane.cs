using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp.Vehicles
{
    class Plane : Vehicle
    {
        public int FlightHeight { get; set; }

        public Plane(int xCoord, int yCoord, int zCoord, int price, int speed, DateTime year, int numberOfPassenger, int flightHeight)
                : base(xCoord, yCoord, zCoord, price, speed, year)
        {
            NumberOfPassenger1 = numberOfPassenger;
            FlightHeight = flightHeight;

        }

        private int _numberOfPassenger;
        public int NumberOfPassenger1
        {
            get
            {
                return _numberOfPassenger;
            }
            set
            {
                if (value < 10)
                {
                    // Console.WriteLine("The number of passengers is less then minimal");
                    throw new ArgumentException("The number of passengers is less then minimal");
                }
                else
                    _numberOfPassenger = value;
            }
        }

        public override string ToString()
        {
            return $"XCoord:{XCoord},YCoord:{YCoord},ZCoord:{ZCoord},TravelPrice:{Price},\nSpeed:{Speed}," +
                $"Year {YearOfIssue}, NumberOfpassenger {NumberOfPassenger1},FlightHeight:{FlightHeight}\n";
        }
    }
}
