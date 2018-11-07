using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp.Vehicles
{
    class Ship:Vehicle
    {

        public Ship(int xCoord, int yCoord, int zCoord, int price, int speed, DateTime year, int numberOfPassenger, string homePort)
               : base(xCoord, yCoord, zCoord, price, speed, year)
        {
            NumberOfPassenger1 = numberOfPassenger;
            HomePort = homePort;

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
                    Console.WriteLine($"The number of passengers is less then minimal +{Environment.NewLine}");
                }
                else
                    _numberOfPassenger = value;
            }
        }
        public string HomePort { get; set; }

        public override string ToString()
        {
            return $"XCoord:{XCoord},YCoord:{YCoord},ZCoord:{ZCoord},TravelPrice:{Price},\nSpeed:{Speed}," +
                $"Year {YearOfIssue}, NumberOfpassenger {NumberOfPassenger1},HomePort:{HomePort}\n";
        }
    }
}
