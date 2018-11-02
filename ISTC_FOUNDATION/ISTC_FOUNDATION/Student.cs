using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC_FOUNDATION
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        private int _age;

       
        public int Age
        {
            get { return _age; }
            set
            {
                if(value<=10 || value >= 50)// Who can participate
                {
                    _age = value;
                }
                
            }
        }


        public Student(string firstName, string lastName, int age, Gender gender, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Phone = phone;
        }


    }
}
