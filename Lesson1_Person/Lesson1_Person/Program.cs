using System;

namespace Lesson1_Person
{

    class Program
    {
        static void Main(string[] args)
        {
            //Аpproach N:3 from the book Тroelsen
            Person person1 = new Person(10);//int
            Person person11 = new Person("string");//string

            Person person2 = new Person(10, "string");
            Person Person21 = new Person("string", 10);

            Person person3 = new Person("string", 10, "string1");
            Person person31 = new Person("string", "string", 10);
            Person person32 = new Person(10, "string", "string");


            Person person4 = new Person(Gender.Unknown, "string", "string",20);

            //Аpproach N:1 from the book Jeffrey Richter
            Person person41 = new Person( "string","string",80,20,Gender.Male);
            Person person42 = new Person( "string", "string");
            Person person43 = new Person("string", "string",20,Gender.Female);







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