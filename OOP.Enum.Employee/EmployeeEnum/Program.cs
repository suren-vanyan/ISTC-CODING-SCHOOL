using System;

namespace EmployeeEnum
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of hours worked");
            int hours = int.Parse(Console.ReadLine());
           
            Accountant accountant = new Accountant();
           
            Array workers = Enum.GetValues(typeof(WorkPositions));
            for (int i = 0; i < workers.Length; i++)
            {
                if (accountant.AskForBonus((WorkPositions)workers.GetValue(i), hours))
                {
                    Console.WriteLine($"Give a bonus to an {workers.GetValue(i)}");
                }
            }

            Console.WriteLine(new string('*',50));
            //OR

            foreach (var worker in Enum.GetValues(typeof(WorkPositions)))
            {
                if (accountant.AskForBonus((WorkPositions)worker, hours))
                {
                    Console.WriteLine($"Give a bonus to an {worker}");
                }
            }
        }
    }
}
