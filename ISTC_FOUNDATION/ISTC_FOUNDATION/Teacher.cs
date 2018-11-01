using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC_FOUNDATION
{
    class Teacher
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private Gender _gender;
        private string _work;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }

        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        internal Gender Gender { get { return _gender; } set { _gender = value; } }

        public string Work { get { return _work; } set { _work = value; } }

        public Teacher()
        {

        }
        public Teacher(string firstName, string lastName, DateTime dateOfBirth, Gender gender, string work)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Work = work;
        }
    }
}
