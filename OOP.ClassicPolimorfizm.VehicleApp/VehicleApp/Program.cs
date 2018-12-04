using System;
using VehicleApp.Vehicles;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //UpCast 
            Vehicle[] vehicles = new Vehicle[3];
            try
            {
               
                vehicles[0] = new Ship(10, 20, 30, 100000, 90, new DateTime(2005, 05, 11), 50, "PORTO BELLO ");
                vehicles[1] = new Car(15, 25, 35, 20000,  new DateTime(2011, 01, 26), 250, 300);
            }
            catch (IndexOutOfRangeException ex) { Console.WriteLine(ex.Message+ "\n" + ex.StackTrace); }
           
            catch(ArgumentException arg) { Console.WriteLine(arg.Message+"\n"+arg.StackTrace); }
           
            catch (Exception e) { Console.WriteLine(e.Message+ "\n" + e.StackTrace); }
            finally
            {
                
                vehicles[2] = new Plane(85, 25, 69, 500000, 200, new DateTime(2017, 01, 25), 150, 2000);
            }

         
            //DownCast
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Ship)
                {
                    Console.WriteLine(vehicle);
                }

                else if((vehicle as Car) != null)
                {
                    Console.WriteLine(vehicle);
                }
                else if(vehicle is Plane e)//C#7
                {
                    Console.WriteLine(e);
                }
            }
           

        }
    }
}
