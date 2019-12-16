using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsMyPizza
{
    public class Cart
    {
        public List<Pizza> cartItems { get; set; }

        public Cart()
        {
            cartItems = new List<Pizza>() { };
        }

        public void AddToCart(Pizza pizza)
        {
            this.cartItems.Add(pizza);
        }

        public void ShowCart()
        {
            foreach(Pizza pizza in cartItems)
            {
                pizza.display(); 
            }
            Console.WriteLine("Press Enter To Go Back To Main Menu");
            Console.ReadLine();
        }
    }
}
