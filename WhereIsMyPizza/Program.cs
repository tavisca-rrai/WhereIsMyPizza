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

            while (inputFromUser != "q")
            {
                switch (inputFromUser)
                {
                    case "0":
                        MenuManager.DisplayPizza();
                        MenuManager.GetPizza();

                        PizzaProvider.DisplayCrust();
                        MenuManager.GetCrust();

                        PizzaProvider.DisplayToppings();
                        MenuManager.GetToppings();
                        
                        MenuManager.GetQuantity();

                        var pizza = MenuManager.sendToCart();
                        MenuManager.clearKitchen();

                        CartManager.cart = new Cart();
                       
                        CartManager.cart.AddToCart(pizza);

                        Console.Clear();

                        WelcomeScreen();


                        break;

                    case "1":
                        //show the cart content 
                        CartManager.cart.ShowCart();
                        break;

                    case "2":
                        break;

                }

                Console.Clear();
                WelcomeScreen();
                inputFromUser = Console.ReadLine();
            }

        }
    }
}
