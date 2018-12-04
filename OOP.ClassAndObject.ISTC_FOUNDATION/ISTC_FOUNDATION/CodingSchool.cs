using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC_FOUNDATION
{

    class CodingSchool
    {
        public CSharpProgramming CSharpCourse { get; set; }
        public string CyberSecurity { get; set; }
        public string MachineLearning { get; set; }
        public string PythonProgramming { get; set; }
        public string JSBootcamp { get; set; }

        public CodingSchool(CSharpProgramming CSharpCourse)
        {
            this.CSharpCourse = CSharpCourse;


        }
    }
}
