using System;
using System.Collections;

namespace EntityAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            //Implicit IVolitionalActions implementation
            human.Voice();
            human.Eat();
            human.Move();
            //Implicit IInstinctiveАctions implementation
            human.Breathe();
            
            //human.Think();
            //human.Rejoice();
            IPurposefulAction purposeful = human as IPurposefulAction;
            purposeful.Rejoice();
            purposeful.Think();
        
            IPurposefulAction human2 = new Human(); //now I can call all methods
            Console.WriteLine(human2.GetType().Name + "\n");


//////////////////////////////////////////////////////////////////////////////////////////////////////

            Dog dog = new Dog();
            // must use casting to access Breathe() Eat()  Move()  Voice()
            IInstinctiveАctions instincDog = dog;
            instincDog.Breathe();

            ((IVolitionalActions)dog).Eat();
            (dog as IVolitionalActions).Move();
            if (dog is IVolitionalActions e)
            {
                e.Voice();
            }
            

            // must use casting to access  Eat()  Move()  Voice()
            IVolitionalActions volitionalDog = dog;
            volitionalDog.Eat();
            volitionalDog.Move();
            volitionalDog.Voice();
            Console.WriteLine(volitionalDog.GetType().Name + "\n");

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            IVolitionalActions[] volitional = new IVolitionalActions[]
            {
                new Human(),new Dog(),new Hen(),new Monkey()
            };

            foreach (var item in volitional)
            {
                if(item is IPurposefulAction a)
                {       
                 
                    a.Think();
                    a.Rejoice();
                    Console.WriteLine($"{item.GetType().Name} \n");
                }

                if(item as IInstinctiveАctions!=null)
                {
                    
                    item.Eat();
                    item.Move();
                    item.Voice();
                    Console.WriteLine($"{item.GetType().Name} \n");
                }
            }


            // This array can only contain types that
            // implement the IInstinctiveАctions interface.
            IInstinctiveАctions[] instinctive = new IInstinctiveАctions[]
            {
               new Human(),new Dog(),new Hen(),new Monkey(),
            };



            // This array can only contain types that
            // implement the IPurposefulAction interface.
            IPurposefulAction[] purposefuls = new IPurposefulAction[]
            {
                new Human(),new Human()//only human implemented interface
            };


////////////////////////////////////////////////////////////////////////////////////////////////////////////
            EntityCollection entityCollection = new EntityCollection();
            //will  find the explicit GetEnumertor in the background
            foreach (var item in entityCollection)
            {
               if(item is Human h)
                {
                    h.Breathe();
                    h.Eat();
                    h.Move();
                    h.Voice();
                    ((IPurposefulAction)h).Rejoice();
                    ((IPurposefulAction)h).Think();

                }
            }

            IInstinctiveАctions[] instinctives = new IInstinctiveАctions[4];

           // will not find the explicit GetEnumertor
            IEnumerator enumerator = entityCollection.GetEnumerator();    
            enumerator.MoveNext();
            Console.WriteLine("\n");
            for (int i = 0; i < 4; i++)
            {
                instinctives[i] =(IInstinctiveАctions) enumerator.Current;
                Console.WriteLine($"{instinctive[i].GetType().Name}");
                
            }
         

        }
    }
}
