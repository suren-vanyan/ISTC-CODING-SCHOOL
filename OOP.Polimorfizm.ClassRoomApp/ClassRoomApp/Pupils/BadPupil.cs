using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoomApp
{
    class BadPupil:Pupil
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BadPupil(string firstName, string lastName,ConsoleColor color)
        {
          this.color = color;
            FirstName = firstName;
            LastName = lastName;
        }

      
        public override void Study()
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine($"{FirstName+ " " + LastName} is a very bad Pupil․He doesn't like learning at all ");
        }

        public override void Read()
        {
            Console.WriteLine($"He doesn't like to reading");
        }

        public override void Write()
        {
            Console.WriteLine($"{FirstName} does not event want to think about writing ");
        }

        public override void Relax()
        {
            Console.WriteLine("But he likes to rest ver much");
        }
    }
}
