using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;

namespace OOP.Extension_Methods.Task8
{
    //It is common practice to not only isolate extension methods into a dedicated.NET namespace but to
    //isolate them into a dedicated class library. In this way, new applications can “opt in” to extensions by explicitly
    //referencing the correct library and importing the namespace.====>

    using MyExtensionMethods;
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"Name=>{FirstName},SurName=>{LastName},Age=>{Age}";
        }
    }

    class Demonstration : IEnumerable<Person>
    {
        Person[] people = new Person[]
        {
            new Person{FirstName="Suren",LastName="Vanyan",Age=25},
             new Person{FirstName="Antony ",LastName="Joshua",Age=29},
             new Person{FirstName="Deontey ",LastName="Wilder",Age=33},

        };

        public IEnumerator<Person> GetEnumerator()
        {
            foreach (var item in people)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in people)
            {
                yield return item;
            }
        }
    }

    class Program
    {
     
        static void Main(string[] args)
        {

            string[] data = { "I", "Love", "You", "Babe", "of", "(^_^)" };
            data.Print();

            Demonstration demo = new Demonstration();
            demo.Print();

            int x = 123456789;
            x = x.ReverseNumber();
            Console.WriteLine(x);

            Console.Write("Number:");
            string str = Console.ReadLine() + Environment.NewLine;//enter number
            int result = str.ConvertToInt();
            Console.WriteLine("Result:" + result);
        }
    }
}
