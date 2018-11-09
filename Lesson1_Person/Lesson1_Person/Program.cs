using System;

namespace Lesson1_Person
{

    class Program
    {
        static void Main(string[] args)
        {
            //Аpproach N:3 from the book Тroelsen
            Person person1 = new Person(10);
            Console.WriteLine(person1);
            Console.WriteLine(new string('*',50));

            Person person11 = new Person("string");//string
            Console.WriteLine(person11);
            Console.WriteLine(new string('*', 50));

            Person person2 = new Person(10, "string");
            Console.WriteLine(person2);
            Console.WriteLine(new string('*', 50));

            Person person21 = new Person("string", 10);
            Console.WriteLine(person21);
            Console.WriteLine(new string('*', 50));

            Person person3 = new Person("string", 10, "string1");
            Console.WriteLine(new string('*', 50));
            Person person31 = new Person("string", "string", 10);
            Console.WriteLine(new string('*', 50));
            Person person32 = new Person(10, "string", "string");
            Console.WriteLine(person31);
            Console.WriteLine(new string('*', 50));


            Person person4 = new Person(Gender.Unknown, "string", "string",20);
            Console.WriteLine(person4);
            Console.WriteLine(new string('*', 50));

            //Аpproach N:1 from the book Jeffrey Richter
            Person person41 = new Person( "string","string",80,20,Gender.Male);
            Console.WriteLine(new string('*', 50));
            Person person42 = new Person( "string", "string");
            Console.WriteLine(new string('*', 50));
            Person person43 = new Person("string", "string",20,Gender.Female);
            Console.WriteLine(person43);
            Console.WriteLine(new string('*', 50));







            //Show field of instance person1

            //person1.ShowFirstName();
            //person1.ShowLastName();
            //person1.ShowAge();
            //person1.ShowWeight();
            //person1.ShowSex();

            Console.WriteLine(new string('*', 50));
            //Mutate fileds of instance person1
            //person1.MutateFirstName("Karls");
            //person1.MutateLastName("Marks");
            //person1.MutateAge(200);
            //person1.MutateAge(70);
            //person1.MutateSex("Male");

            //Show mutate fields of instance person1

            //Console.WriteLine("After chnage");
            //person1.ShowFirstName();
            //person1.ShowLastName();
            //person1.ShowAge();
            //person1.ShowWeight();
            //person1.ShowSex();

        }
    }
}