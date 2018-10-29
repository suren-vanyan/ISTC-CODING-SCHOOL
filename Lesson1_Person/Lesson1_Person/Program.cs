using System;

namespace Lesson1_Person
{
    //enum Sex
    //{
    //    Male,
    //    Female
    //}

    class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _weight;
        private string _sex;
        //private Sex _sex;

        public Person(string firstName, string lastName, int age, int weight, string sex)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            this._weight = weight;
            this._sex = sex;
        }

        public Person()
        {
            //Default Ctor
        }

        public void MutateFirstName(string firstName)
        {
            this._firstName = firstName;
        }

        public void MutateLastName(string lastName)
        {
            this._lastName = lastName;
        }

        public void MutateAge(int age)
        {
            this._age = age;
        }

        public void MutateWeight(int weight)
        {
            this._weight = weight;
        }

        public void MutateSex(string sex)
        {
            this._sex = sex;
        }

        public void Show()
        {
            Console.WriteLine($"firstname:[{_firstName}],lasname:[{_lastName}]," +
                               $"age:[{_age}] ,weight:[{_weight}],sex:[{_sex}]");

            Console.WriteLine(new string('-', 50));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person("Adam", "Smith", 295, 80, "Male");
            Person person2 = new Person("Karl", "Marks", 200, 70, "Male");
            Person person3 = new Person("Marie", "Curie", 151, 58, "Female");

            person.Show();
            person.MutateFirstName("David");
            person.MutateLastName("Ricardo");
            person.Show();

            person1.Show();
            person1.MutateAge(85);
            person1.MutateWeight(98);
            person1.Show();

            person2.Show();
            person3.Show();


        }
    }
}