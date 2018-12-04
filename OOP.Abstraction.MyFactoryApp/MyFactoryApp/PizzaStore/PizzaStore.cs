using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryApp
{
   public abstract class PizzaStore
    {
       
        public Pizza OrderPizza(string typeOfPizza)
        {
            Pizza pizza;
            pizza = CreatePizza(typeOfPizza);
            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }
           
            return pizza;
        }

       public abstract Pizza CreatePizza(string typeOfPizza);
    }
}
