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

        
        
        public void ShowFirstName()
        {
            Console.WriteLine($"firstname:{_firstName}");
        }

        public void ShowLastName()
        {
            Console.WriteLine($"lastname:{_lastName}");
        }

        public void ShowAge()
        {
            Console.WriteLine($"Age:{_age}");
        }

        public void ShowWeight()
        {
            Console.WriteLine($"Weight:{_weight}");
        }

        public void ShowSex()
        {
            Console.WriteLine($"Sex:{_sex}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person("Adam", "Smith", 295, 80, "Male");
          

            //Show field of instance person1

            person1.ShowFirstName();
            person1.ShowLastName();
            person1.ShowAge();
            person1.ShowWeight();
            person1.ShowSex();

            Console.WriteLine(new string('*',50));
            //Mutate fileds of instance person1
            person1.MutateFirstName("Karls");
            person1.MutateLastName("Marks");
            person1.MutateAge(200);
            person1.MutateAge(70);
            person1.MutateSex("Male");

            //Show mutate fields of instance person1
            Console.WriteLine("After chnage");
            person1.ShowFirstName();
            person1.ShowLastName();
            person1.ShowAge();
            person1.ShowWeight();
            person1.ShowSex();
           
        }
    }
}