using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAction
{
    internal class Human : IInstinctiveАctions, IVolitionalActions,IPurposefulAction
    {
        //Implicit interface implementation
        
        public void Breathe()
        {
            Console.WriteLine("The Man breathes");
        }

        public void Eat()
        {
            Console.WriteLine("The Man Eats");
        }

        public void Move()
        {
            Console.WriteLine("The Man moves");
        }

        public void Voice()
        {
            Console.WriteLine("Ara hly sus mnaceq eeeee");
        }

        //explicit interface implementation
         void IPurposefulAction.Rejoice()
        {
            Console.WriteLine("The Man rejoys");
        }

         void IPurposefulAction.Think()
        {
            Console.WriteLine("The Man thinks");
        }
    }
}
