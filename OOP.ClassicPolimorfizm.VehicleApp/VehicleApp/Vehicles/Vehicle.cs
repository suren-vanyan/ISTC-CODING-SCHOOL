using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleApp.Vehicles
{
    class Vehicle
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int ZCoord { get; set; }


        public  int Price { get; set; }
        public virtual int Speed { get; set; }
        public DateTime YearOfIssue { get; set; }

        public Vehicle(int xCoord,int yCoord,int zCoord,int travelPrice,int speed,DateTime year)
                      
        {
            XCoord = XCoord;
            YCoord = yCoord;
            ZCoord = zCoord;
            Price = travelPrice;
            Speed = speed;
            YearOfIssue = year;
        }

        public Vehicle()
        {

        }
    }
}
