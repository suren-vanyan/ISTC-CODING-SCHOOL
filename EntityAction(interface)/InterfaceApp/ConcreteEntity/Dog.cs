using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAction
{
    class Dog : IInstinctiveАctions, IVolitionalActions
    {

        //explicit interface implementation

        void IInstinctiveАctions.Breathe()
        {
            Console.WriteLine("The Dog breathes");
        }

        void IVolitionalActions.Eat()
        {
            Console.WriteLine("The Dog Eats");
        }

        void IVolitionalActions.Move()
        {
            Console.WriteLine("The Dog moves");
        }

        void IVolitionalActions.Voice()
        {
            Console.WriteLine("The dog barks Haf-Haf");
        }
    }
}
