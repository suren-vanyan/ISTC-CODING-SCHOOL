using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC_FOUNDATION
{
    class CSharpProgramming
    {
         
        private static int _courseTotalPrice;
        private static int _courseTotalHours;
        private Stage _stage;
        public static Teacher[] teachers { get; set; }
        public Student[] participants { get; set; }

        public static int CourseTotalPrice { get => _courseTotalPrice; set => _courseTotalPrice = value; }
        public static int CourseTotalHours { get => _courseTotalHours; set => _courseTotalHours = value; }
        internal Stage Stage { get => _stage; set => _stage = value; }


        #region Constructors

        static CSharpProgramming()
        {
            CourseTotalHours = 144;//hours
            CourseTotalPrice = 240000;//$$$$$
            teachers = new Teacher[2]
            {
                new Teacher("Tigran","Vardanyan",new DateTime(1992, 08, 31),Gender.Male,"ISTC"),
                new Teacher("Vanik", "Hakobyan", new DateTime(1992, 08, 31), Gender.Male,"BETCONSTRUCT")
            };
        }


        #endregion

    }
}
