using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1_Person
{
    class Person
    {
        //fields
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _weight;
        private Gender _gender;

        //Only Get Property
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public int Age { get => _age; }
        public int Weight { get => _weight; }
        internal Gender Gender { get => _gender; }

        // Every writer says his approach is better

        #region Аpproach N:1 from the book Jeffrey Richter
        //public Person()
        //{
        //    Console.WriteLine("Default ctor");

        //    _firstName = "Jeffrey";
        //    _lastName = "Richter";
        //    _age = 50;
        //    _weight = 80;
        //    _gender = Gender.Unknown;
        //}

        public Person(string firstName, string lasnName) : this()
        {
            _firstName = firstName;
            _lastName = lasnName;
        }

        public Person(Gender gender, string lasnName) : this()
        {
            _gender = gender;
            _lastName = lasnName;
        }

        public Person(string firstName, string lasnName, int weight, Gender gender) : this()
        {
            _firstName = firstName;
            _lastName = lasnName;
            _weight = weight;
            _gender = gender;
        }

        public Person(string firstName, string lasnName, int age, int weight, Gender gender) : this()
        {
            _firstName = firstName;
            _lastName = lasnName;
            _age = age;
            _gender = gender;
            _weight = weight;

        }
        #endregion


        #region  Approach N:2(descending)

        //I specifically did this to avoid conflict
        public Person(Gender gender, string firstName, string lastName, int weight, int age)
                        : this(age: age, gender: gender, firstName: firstName, lastName: lastName)
        {
            _weight = weight;
        }

        public Person(Gender gender, string firstName, string lastName, int age) : this(gender, lastName: lastName, firstName: firstName)
        {
            _age = age;
        }

        public Person(Gender gender, string firstName, string lastName) : this(lastName: lastName, gender: gender)
        {
            _firstName = firstName;
        }

        public Person(string lastName, Gender gender):this(gender)
        {
            _lastName = LastName;

        }

        public Person(Gender gender) : this()
        {
            _gender = gender;
        }

        #endregion


        #region Аpproach N:3 from the book Тroelsen  (ascending)

        public Person(string firstName, int age, string lastName, int weight, Gender gender)
        {

            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _weight = weight;
            _gender = gender;
        }

        public Person(string firstName, int age, string lastName, int weight) : this(firstName, age, lastName, weight, default(Gender))
        {

            Console.WriteLine(" talking string,int,string,int");
            //_firstName = firstName;   
            //_lastName=lastName;
            //_age = age;

        }

        public Person(int age, string firstName, string lastName) : this(firstName, age, lastName, default(int))
        {
            Console.WriteLine(" talking int,string,string");
            //_firstName = firstName;       
            //_age = age;
            //_lastName=lastName;
        }

        //I specifically did this
        public Person(string firstName, string lastName, int age) : this(firstName, lastName: lastName, age: age, weight: default(int))
        {
            Console.WriteLine(" talking string,string,int ");
            //_firstName = firstName;       
            //_age = age;
            //_lastName=lastName;
        }

        public Person(string firstName, int age, string lastName) : this(age: age, firstName: firstName, weight: default(int), lastName: lastName)
        {

            Console.WriteLine(" talking string,int,string");
            //_firstName = firstName;       
            //_age = age;
            //_lastName=lastName;
        }

        public Person(int age, string lastName)
        {

            Console.WriteLine(" talking int,string");
            //_age = age;
            //_lastName=lastName;
        }
        public Person(string firstName, int age) : this(firstName, age, string.Empty)
        {

            Console.WriteLine(" talking string,int");
            //_firstName = firstName;
            //_age = age;
        }

        public Person(int age) : this(string.Empty, age)
        {

            Console.WriteLine(" talking int");
            // _age = age;
        }
        public Person(string firstName) : this(firstName, default(int))
        {

            Console.WriteLine(" talking string");
            //  _firstName = firstName;
        }

        #endregion

        // Аpproach N:4
        //is used as a default constructor
        public Person(string firstName = "firstName", string lastName = "lastName", Gender gender = default(Gender), int age = default(int), int weight = default(int))
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _weight = weight;
            _gender = gender;
        }


        public override string ToString()
        {
            return string.Format($"{this.GetType()} FirstName{FirstName},LastName{LastName},Age{Age},Weight{Weight},Gender {(int)Gender},");
        }



        #region Mutate

        //public void MutateFirstName(string firstName)
        //{
        //    this._firstName = firstName;
        //}

        //public void MutateLastName(string lastName)
        //{
        //    this._lastName = lastName;
        //}

        //public void MutateAge(int age)
        //{
        //    this._age = age;
        //}

        //public void MutateWeight(int weight)
        //{
        //    this._weight = weight;
        //}

        //public void MutateSex(Gender gender)
        //{
        //    this._gender = gender;
        //}
        #endregion

        #region Print
        //public void ShowFirstName()
        //{
        //    Console.WriteLine($"firstname:{_firstName}");
        //}

        //public void ShowLastName()
        //{
        //    Console.WriteLine($"lastname:{_lastName}");
        //}

        //public void ShowAge()
        //{
        //    Console.WriteLine($"Age:{_age}");
        //}

        //public void ShowWeight()
        //{
        //    Console.WriteLine($"Weight:{_weight}");
        //}

        //public void ShowSex()
        //{
        //    Console.WriteLine($"Sex:{_sex}");
        //}
        #endregion

    }
}