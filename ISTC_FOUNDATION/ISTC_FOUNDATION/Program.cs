using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC_FOUNDATION
{
    class Program
    {
        static void Main(string[] args)
        {
            CodingSchool coding = new CodingSchool(new CSharpProgramming());     
            coding.CSharpCourse.Stage = Stage.EssentialOOP;
            coding.CSharpCourse.participants = new Student[]
            {
               new Student("Tozdumanyan","Qanduqarap",32,Gender.Male,"077235689"),
               new Student("Poxos","Poxosyan",28,Gender.Male,"098452635"),
               new Student("Siradexyan","Arshaluys",40,Gender.Male,"2555555557"),
               new Student("Andreasyan","Haykanush",36,Gender.Female,"55547775111"),
            };


        }
    }
}
