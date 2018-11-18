using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAction
{
    class Monkey : IInstinctiveАctions, IVolitionalActions
    {
        //Implicit interface implementation
        public void Breathe()
        {
            Console.WriteLine("The Monkey breathes");
        }

        public void Eat()
        {
            Console.WriteLine("The Monkey eats Banane");
        }

        public void Move()
        {
            Console.WriteLine("The Monkey moves");
        }

        public void Voice()
        {
            Console.WriteLine("tralyalyalyalyalya");
        }
    }
}
