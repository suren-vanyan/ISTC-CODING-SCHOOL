using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoomApp
{
    class ClassRoom
    {
        private static int countofPupil;
        public Pupil[] pupils=new Pupil[4];

      
        public ClassRoom(Pupil pupil1,Pupil pupil2,Pupil pupil3,Pupil pupil4)
        {
          
            pupils[countofPupil++] = pupil1;
            pupils[countofPupil++] = pupil2;
            pupils[countofPupil++] = pupil3;
            pupils[countofPupil++] = pupil4;


        }

        public int GetCountOfPupils()
        {
            return countofPupil;
        }
    }
}
