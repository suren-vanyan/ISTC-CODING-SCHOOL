using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoomApp
{
    class GoodPupil:Pupil
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        

        public GoodPupil(string name,string surName, ConsoleColor color)
        {
            this.color = color;
             Name = name;
            SurName = surName;
        }

        public override void Study()
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine($"{Name} { SurName} is a  good Pupil․ He  likes to learning  ");
        }

        public override void Read()
        {
            Console.WriteLine($"He  likes to read ");
        }

        public override void Write()
        {
            Console.WriteLine($"and write ");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} rest when he finishes his lessons");
        }
    }
}
