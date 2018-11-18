using System;
using System.Collections.Generic;
using System.Text;

namespace EntityAction
{
    class Hen : IInstinctiveАctions, IVolitionalActions
    {
        //explicit interface implementation
        void IInstinctiveАctions.Breathe()
        {
            Console.WriteLine("The Hen breathes");
        }

         void IVolitionalActions.Eat()
        {
            Console.WriteLine("The Hen Eats");
        }

         void IVolitionalActions.Move()
        {
            Console.WriteLine("the Hen moves");
        }

         void IVolitionalActions.Voice()
        {
            Console.WriteLine("The Hen breeds voice Krya-Krya-Krya");
        }
    }
}
