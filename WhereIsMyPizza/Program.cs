using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsMyPizza
{
    class Program
    {
        public static void WelcomeScreen()
        {
            Console.WriteLine("Where is My Pizzzzzaaaaaaaaaaaaaaaaaaa\n\n");
            Console.WriteLine("For The Menu Enter 0\n");
            Console.WriteLine("For The Cart Enter 1\n");
            Console.WriteLine("For The Payment Enter 2\n");
            Console.WriteLine("\nTo Exit,Enter any of the rest\n");

        }
        static void Main(string[] args)
        {
            WelcomeScreen();

            string inputFromUser = "";
            inputFromUser=Console.ReadLine();

            switch(inputFromUser)
            {
                case "0" :
                    MenuManager.DisplayPizza();
                    MenuManager.GetPizza();

                    PizzaProvider.DisplayCrust();
                    MenuManager.GetCrust();

                    PizzaProvider.DisplayToppings();
                    MenuManager.GetToppings();

                    var pizza = MenuManager.sendToCart();
                    MenuManager.clearKitchen();

                    CartManager.cart = new Cart();
                    // Cart cart = new Cart();
                    CartManager.cart.AddToCart(pizza);
                    //cart.AddToCart(pizza);



                    

                    break;

                case "1":
                    //show the cart content 
                    CartManager.cart.ShowCart();
                    break;

                case "2":
                    break;

            }




        }
    }
}
