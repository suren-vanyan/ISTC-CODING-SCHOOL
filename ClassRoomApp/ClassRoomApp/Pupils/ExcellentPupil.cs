using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoomApp
{
    class ExcellentPupil:Pupil
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public ExcellentPupil(string firstName,string lastName, ConsoleColor color)
        {
            this.color = color;
            FirstName = firstName;
            LastName = lastName;
        }

        public override void Study()
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine($"{FirstName} {LastName} is a very good Pupil․ He likes studying very much  ");
        }

        public override void Read()
        {
            Console.WriteLine($"He reads a lot ");
        }

        public override void Write()
        {
            Console.WriteLine($"and writes ");
        }

        public override void Relax()
        {
            Console.WriteLine($"He has almost no time to rest");
        }
    }
}
