using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EntityAction
{
    class EntityCollection : IEnumerable
    {
        private IVolitionalActions[] volitionals = new IVolitionalActions[4];
        public EntityCollection()
        {
            volitionals[0] = new Human();
            volitionals[1] = new Monkey();
            volitionals[2] = new Hen();
            volitionals[3] = new Dog();
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return volitionals.GetEnumerator();
        }


        public IEnumerator GetEnumerator()
        {
            return volitionals.GetEnumerator();
        }

    }
}
