using System;

namespace EntityAction
{
    class Program
    {
        public static void Print()
        {

        }
        static void Main(string[] args)
        {
            Human human = new Human();
            //Implicit IVolitionalActions implementation
            human.Voice();
            human.Eat();
            human.Move();
            //Implicit IInstinctiveАctions implementation
            human.Breathe();
            Console.WriteLine(human.GetType().Name);
            //human.Think();
            //human.Rejoice();
            IPurposefulAction ppf = human as IPurposefulAction;
            ppf.Rejoice();
            ppf.Think();
        
            IPurposefulAction human2 = new Human(); //now I can call all methods

//////////////////////////////////////////////////////////////////////////////////////////////////////
            Dog dog = new Dog();
            // must use casting to access Breathe() Eat()  Move()  Voice()
            IInstinctiveАctions instincDog = dog;
            instincDog.Breathe();

            // must use casting to access  Eat()  Move()  Voice()
            IVolitionalActions volitionalDog = dog;
            volitionalDog.Eat();
            volitionalDog.Move();
            volitionalDog.Voice();

          
//////////////////////////////////////////////////////////////////////////////////////////////////////

            IVolitionalActions[] volitional = new IVolitionalActions[]
            {
                new Human(),new Dog(),new Hen(),new Monkey()
            };

            foreach (var item in volitional)
            {
                if(item is IPurposefulAction e)
                {       
                    Console.WriteLine($"{item.GetType().Name}");
                    e.Think();
                    e.Rejoice();
                }

                if(item as IInstinctiveАctions!=null)
                {
                    Console.WriteLine($"{item.GetType().Name}");
                    item.Eat();
                    item.Move();
                    item.Voice();
                }
            }


            // This array can only contain types that
            // implement the IPointy interface.
            IInstinctiveАctions[] instinctive = new IInstinctiveАctions[]
            {
               new Human(),new Dog(),new Hen(),new Monkey(),
            };


            // This array can only contain types that
            // implement the IPointy interface.
            IPurposefulAction[] purposefuls = new IPurposefulAction[]
            {
                new Human(),new Human()//only human implemented interface
            };
        }
    }
}
