using System;
using System.Collections.Generic;
using System.Text;

namespace MyFactoryApp
{
    class GumriPizzaStore : PizzaStore
    {
         public override Pizza CreatePizza(string typeOfPizza)
        {
            
                Pizza pizza = null;
                switch (typeOfPizza.ToLower())
                {
                    
                case "margherita":
                    pizza = new Margherita("Margherita", "with tomatoes, mozzarella , olive oil and basil");
                    break;
                case "diabola":
                    pizza = new Diabola("Diabola", "with salami and hot Calabrian pepper.");
                    break;
                case "hawaii":
                    pizza = new Hawaii("Hawaii", "with ham and pineapple");
                    break;
                default:
                        break;
                }

                return pizza;
            
        }
    }
}
