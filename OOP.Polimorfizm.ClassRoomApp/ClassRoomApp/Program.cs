using System;

namespace ClassRoomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcast
            Pupil firstExcellentPupil = new ExcellentPupil("Grady", "Buch", ConsoleColor.Red);          
            Pupil sexondExcellentPupil = new ExcellentPupil("Jeffrey", "Richter", ConsoleColor.Green);
            Pupil goodPupil = new GoodPupil("Herbert", "Shildt", ConsoleColor.Blue);
            Pupil badPupil = new BadPupil("Hillary", "Clinton",ConsoleColor.DarkGray);

            
            ClassRoom classRoom = new ClassRoom(firstExcellentPupil, sexondExcellentPupil, goodPupil, badPupil);

            Console.WriteLine($"There are {classRoom.GetCountOfPupils()} pupils in the Classroom");
            Console.WriteLine($"{new string('*',50)}\n");

            // I did experiments in project,to reinforce knowledge of Polymorphism

            foreach (Pupil pupil in classRoom.pupils)
            {
                //DownCast
                if(pupil is ExcellentPupil e)
                {
                    e.Study();
                    e.Read();
                    e.Write();
                    e.Relax();
                    Console.WriteLine($"{new string('*', 50)}\n");
                  //  Console.ResetColor();
                }

                //DownCast
                else if ((pupil as GoodPupil) != null)
                {
                    pupil.Study();
                    pupil.Read();
                    pupil.Write();
                    pupil.Relax();
                    Console.WriteLine($"{new string('*', 50)}\n");
                   // Console.ResetColor();
                }

                //DownCast
                else if (pupil is BadPupil)
                {
                    Pupil anotherPupil = (Pupil)pupil;
                    anotherPupil.Study();
                    anotherPupil.Read();
                    anotherPupil.Write();
                    anotherPupil.Relax();
                    Console.WriteLine($"{new string('*', 50)}\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
